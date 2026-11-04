using BankaSimulasyonu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaSimulasyonu.Models
{
    public class KrediHesabi : BankaHesabi, IFaizHesapla
    {
        // ── Kredi hesabına özel alanlar ───────────────────────────────
        private double _faizOrani;
        public double KrediLimiti { get; private set; }

        
        public double FaizOranı
        {
            get { return _faizOrani; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Faiz oranı 0-100 arasında olmalıdır.");
                _faizOrani = value;
            }
        }

        // ── Constructor ───────────────────────────────────────────────
        public KrediHesabi(string hesapSahibi, double krediLimiti, double faizOrani)
            : base(hesapSahibi, 0) // Kredi hesabı 0 bakiye ile açılır
        {
            KrediLimiti = krediLimiti;
            FaizOranı = faizOrani;
        }

        // ── IFaizHesapla metotları ────────────────────────────────────
        public double FaizHesapla()
        {
            // Kullanılan kredi üzerinden faiz hesapla
            double kullanilanKredi = -Bakiye;
            if (kullanilanKredi <= 0) return 0;
            return kullanilanKredi * (FaizOranı / 100);
        }

        public void FaizUygula()
        {
            double faiz = FaizHesapla();
            if (faiz > 0)
            {
                Bakiye -= faiz;
                IslemGecmisi.Add($"{DateTime.Now:dd.MM.yyyy HH:mm} | Kredi Faizi: -{faiz:C2} | Bakiye: {Bakiye:C2}");
            }
        }

      
        public override string HesapTuru => "Kredi Hesabı";

        protected override void ParaYatirIslem(double miktar)
        {
          
            IslemGecmisi.Add($"{DateTime.Now:dd.MM.yyyy HH:mm} | Kredi ödemesi yapıldı.");
        }

        protected override void ParaCekIslem(double miktar)
        {
            
            IslemGecmisi.Add($"{DateTime.Now:dd.MM.yyyy HH:mm} | Kredi kullanıldı.");
        }

        protected override bool CekimOnayı(double miktar)
        {
            // Kredi limitini aşıyorsa çekim yapılamaz
            if (Bakiye - miktar < -KrediLimiti)
                throw new InvalidOperationException($"Kredi limiti aşılıyor. Limit: {KrediLimiti:C2}");
            return true;
        }

        protected override bool NegatifBakiyeIzinliMi()
        {
            return true; // Kredi hesabı eksi bakiyeye düşebilir
        }

        public override string RaporOlustur()
        {
            double kullanilanKredi = Math.Max(0, -Bakiye);
            return base.RaporOlustur() +
                   $"\nKredi Limiti     : {KrediLimiti:C2}" +
                   $"\nKullanılan Kredi : {kullanilanKredi:C2}" +
                   $"\nFaiz Oranı       : %{FaizOranı}" +
                   $"\nAylık Faiz       : {FaizHesapla():C2}";
        }
    }
}

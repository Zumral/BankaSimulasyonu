using BankaSimulasyonu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaSimulasyonu.Models
{
    public class VadeliHesap : BankaHesabi, IFaizHesapla
    {
        // ── Vadeli hesaba özel alanlar ────────────────────────────────
        private double _faizOrani;
        public int VadeGun { get; private set; }

        
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
        public VadeliHesap(string hesapSahibi, double baslangicBakiye, double faizOrani, int vadeGun)
            : base(hesapSahibi, baslangicBakiye)
        {
            FaizOranı = faizOrani;
            VadeGun = vadeGun;
        }

        // ── IFaizHesapla metotları ────────────────────────────────────
        public double FaizHesapla()
        {
            // Basit faiz formülü: Bakiye * FaizOranı/100 * VadeGün/365
            return Bakiye * (FaizOranı / 100) * (VadeGun / 365.0);
        }

        public void FaizUygula()
        {
            double faiz = FaizHesapla();
            Bakiye += faiz;
            IslemGecmisi.Add($"{DateTime.Now:dd.MM.yyyy HH:mm} | Faiz Uygulandı: +{faiz:C2} | Bakiye: {Bakiye:C2}");
        }

        // ── Abstract metotların doldurulması ──────────────────────────
        public override string HesapTuru => "Vadeli Hesap";

        protected override void ParaYatirIslem(double miktar)
        {
            // Vadeli hesaba vade dolmadan para yatırılabilir
        }

        protected override void ParaCekIslem(double miktar)
        {
            // Vadeli hesaptan çekim yapılırsa faiz sıfırlanır
            IslemGecmisi.Add($"{DateTime.Now:dd.MM.yyyy HH:mm} | Uyarı: Vade bozuldu, faiz sıfırlandı.");
        }

        protected override bool CekimOnayı(double miktar)
        {
            if (Bakiye < miktar)
                throw new InvalidOperationException("Yetersiz bakiye. Çekim yapılamaz.");
            return true;
        }

        protected override bool NegatifBakiyeIzinliMi()
        {
            return false;
        }

        public override string RaporOlustur()
        {
            return base.RaporOlustur() +
                   $"\nFaiz Oranı  : %{FaizOranı}" +
                   $"\nVade        : {VadeGun} gün" +
                   $"\nTahmini Faiz: {FaizHesapla():C2}";
        }
    }
}

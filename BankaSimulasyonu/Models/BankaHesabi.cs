using BankaSimulasyonu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaSimulasyonu.Models
{
    public abstract class BankaHesabi : IRaporla
    {
        
        private string _hesapNo;
        private string _hesapSahibi;
        private double _bakiye;
        private DateTime _olusturmaTarihi;

        
        public string HesapNo
        {
            get { return _hesapNo; }
            private set { _hesapNo = value; }
        }

        public string HesapSahibi
        {
            get { return _hesapSahibi; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Hesap sahibi adı boş olamaz.");
                _hesapSahibi = value;
            }
        }

        public double Bakiye
        {
            get { return _bakiye; }
            protected set
            {
                if (value < 0 && !NegatifBakiyeIzinliMi())
                    throw new InvalidOperationException("Yetersiz bakiye.");
                _bakiye = value;
            }
        }

        public DateTime OlusturmaTarihi
        {
            get { return _olusturmaTarihi; }
            private set { _olusturmaTarihi = value; }
        }

        public List<string> IslemGecmisi { get; private set; }

        // ── Constructor ───────────────────────────────────────────────
        protected BankaHesabi(string hesapSahibi, double baslangicBakiye)
        {
            HesapNo = HesapNoUret();
            HesapSahibi = hesapSahibi;
            Bakiye = baslangicBakiye;
            OlusturmaTarihi = DateTime.Now;
            IslemGecmisi = new List<string>();
            IslemGecmisi.Add($"Hesap açıldı. Başlangıç bakiye: {baslangicBakiye:C2}");
        }

        
  
        public bool ParaYatir(double miktar)
        {
            if (!MiktarGecerliMi(miktar)) return false;        // ortak kontrol
            ParaYatirIslem(miktar);                            // alt sınıfa özel
            Bakiye += miktar;
            IslemGecmisi.Add($"{DateTime.Now:dd.MM.yyyy HH:mm} | Yatırma: +{miktar:C2} | Bakiye: {Bakiye:C2}");
            return true;
        }

        public bool ParaCek(double miktar)
        {
            if (!MiktarGecerliMi(miktar)) return false;        // ortak kontrol
            if (!CekimOnayı(miktar)) return false;             // alt sınıfa özel onay
            ParaCekIslem(miktar);                              // alt sınıfa özel
            Bakiye -= miktar;
            IslemGecmisi.Add($"{DateTime.Now:dd.MM.yyyy HH:mm} | Çekim: -{miktar:C2} | Bakiye: {Bakiye:C2}");
            return true;
        }

        // ── Abstract Metotlar (alt sınıflar dolduracak) ───────────────
        public abstract string HesapTuru { get; }
        protected abstract void ParaYatirIslem(double miktar);
        protected abstract void ParaCekIslem(double miktar);
        protected abstract bool CekimOnayı(double miktar);
        protected abstract bool NegatifBakiyeIzinliMi();

        // ── Virtual Metot  ─────
        protected virtual bool MiktarGecerliMi(double miktar)
        {
            return miktar > 0;
        }

        // ── IRaporla implementasyonu ──────────────────────────────────
        public virtual string RaporOlustur()
        {
            return $"Hesap No    : {HesapNo}\n" +
                   $"Hesap Türü  : {HesapTuru}\n" +
                   $"Hesap Sahibi: {HesapSahibi}\n" +
                   $"Bakiye      : {Bakiye:C2}\n" +
                   $"Açılış Tarihi: {OlusturmaTarihi:dd.MM.yyyy}";
        }

        // ── Yardımcı metot ────────────────────────────────────────────
        private string HesapNoUret()
        {
            Random rnd = new Random();
            return "TR" + rnd.Next(10000000, 99999999).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaSimulasyonu.Models
{
    public class VadesizHesap : BankaHesabi
    {
        // ── Constructor ───────────────────────────────────────────────
        public VadesizHesap(string hesapSahibi, double baslangicBakiye)
            : base(hesapSahibi, baslangicBakiye)
        {
        }

        // ── Abstract metotların doldurulması ──────────────────────────
        public override string HesapTuru => "Vadesiz Hesap";

        protected override void ParaYatirIslem(double miktar)
        {
            // Vadesiz hesapta özel bir kural yok, para direkt yatar
        }

        protected override void ParaCekIslem(double miktar)
        {
            // Vadesiz hesapta özel bir kural yok, para direkt çekilir
        }

        protected override bool CekimOnayı(double miktar)
        {
            // Bakiye yeterliyse çekim onaylanır
            if (Bakiye < miktar)
                throw new InvalidOperationException("Yetersiz bakiye. Çekim yapılamaz.");
            return true;
        }

        protected override bool NegatifBakiyeIzinliMi()
        {
            return false; // Vadesiz hesap eksi bakiyeye düşemez
        }

        public override string RaporOlustur()
        {
            return base.RaporOlustur() +
                   "\nFaiz        : Uygulanmaz";
        }
    }
}

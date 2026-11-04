using BankaSimulasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaSimulasyonu
{
    public partial class MainForm : Form
    {
        // Tüm hesapları tutan liste (literal veri)
        private List<BankaHesabi> _hesaplar = new List<BankaHesabi>();
        public MainForm()
        {
            InitializeComponent();
            OritekHesaplariYukle();
            TabloYenile();
        }

        // ── Başlangıç için örnek veriler (literal data) ───────────────
        private void OritekHesaplariYukle()
        {
            _hesaplar.Add(new VadesizHesap("Ahmet Yılmaz", 5000));
            _hesaplar.Add(new VadeliHesap("Ayşe Kaya", 10000, 15, 90));
            _hesaplar.Add(new KrediHesabi("Mehmet Demir", 20000, 2.5));
        }

        // ── DataGridView'i güncelle ───────────────────────────────────
        private void TabloYenile()
        {
            dgvHesaplar.Rows.Clear();
            dgvHesaplar.Columns.Clear();

            dgvHesaplar.Columns.Add("HesapNo", "Hesap No");
            dgvHesaplar.Columns.Add("HesapTuru", "Hesap Türü");
            dgvHesaplar.Columns.Add("HesapSahibi", "Hesap Sahibi");
            dgvHesaplar.Columns.Add("Bakiye", "Bakiye");
            dgvHesaplar.Columns.Add("Tarih", "Açılış Tarihi");

            foreach (var hesap in _hesaplar)
            {
                dgvHesaplar.Rows.Add(
                    hesap.HesapNo,
                    hesap.HesapTuru,
                    hesap.HesapSahibi,
                    hesap.Bakiye.ToString("C2"),
                    hesap.OlusturmaTarihi.ToString("dd.MM.yyyy")
                );
            }

            lblDurum.Text = $"Toplam {_hesaplar.Count} hesap listeleniyor.";
        }

        // ── Hesap Aç butonu ───────────────────────────────────────────
        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            HesapAcForm form = new HesapAcForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _hesaplar.Add(form.YeniHesap);
                TabloYenile();
                lblDurum.Text = $"✅ Yeni hesap açıldı: {form.YeniHesap.HesapSahibi}";
            }
        }

        // ── İşlem Yap butonu ─────────────────────────────────────────
        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            if (dgvHesaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz hesabı seçin.",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int seciliIndex = dgvHesaplar.SelectedRows[0].Index;
            BankaHesabi seciliHesap = _hesaplar[seciliIndex];

            IslemForm form = new IslemForm(seciliHesap);
            form.ShowDialog();
            TabloYenile();
            lblDurum.Text = $"💰 İşlem tamamlandı: {seciliHesap.HesapSahibi}";
        }

        // ── Hesap Sil butonu ─────────────────────────────────────────
        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            if (dgvHesaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz hesabı seçin.",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int seciliIndex = dgvHesaplar.SelectedRows[0].Index;
            BankaHesabi seciliHesap = _hesaplar[seciliIndex];

            var onay = MessageBox.Show(
                $"{seciliHesap.HesapSahibi} adlı hesabı silmek istediğinize emin misiniz?",
                "Hesap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                _hesaplar.RemoveAt(seciliIndex);
                TabloYenile();
                lblDurum.Text = $"🗑️ Hesap silindi: {seciliHesap.HesapSahibi}";
            }
        }

        // ── Rapor butonu ─────────────────────────────────────────────
        private void btnRapor_Click(object sender, EventArgs e)
        {
            if (dgvHesaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen rapor almak istediğiniz hesabı seçin.",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int seciliIndex = dgvHesaplar.SelectedRows[0].Index;
            BankaHesabi seciliHesap = _hesaplar[seciliIndex];

            MessageBox.Show(seciliHesap.RaporOlustur(),
                "📋 Hesap Raporu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}

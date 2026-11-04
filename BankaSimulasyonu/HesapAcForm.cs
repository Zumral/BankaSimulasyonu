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
    public partial class HesapAcForm : Form
    {
        public BankaHesabi YeniHesap { get; private set; }
        public HesapAcForm()
        {
            InitializeComponent();
            ComboBoxDoldur();
            AlanlarıGuncelle();
        }

        // ── ComboBox'a hesap türlerini ekle ──────────────────────────
        private void ComboBoxDoldur()
        {
            cmbHesapTuru.Items.Add("Vadesiz Hesap");
            cmbHesapTuru.Items.Add("Vadeli Hesap");
            cmbHesapTuru.Items.Add("Kredi Hesabı");
            cmbHesapTuru.SelectedIndex = 0;
        }

        // ── Seçilen türe göre alanları göster/gizle ──────────────────
        private void AlanlarıGuncelle()
        {
            string secilen = cmbHesapTuru.SelectedItem?.ToString();

            bool vadeli = secilen == "Vadeli Hesap";
            bool kredi = secilen == "Kredi Hesabı";

            lblFaiz.Visible = vadeli || kredi;
            txtFaizOrani.Visible = vadeli || kredi;

            lblVade.Visible = vadeli;
            txtVadeGun.Visible = vadeli;

            lblKrediLimit.Visible = kredi;
            txtKrediLimiti.Visible = kredi;

            lblBakiye.Visible = !kredi;
            txtBakiye.Visible = !kredi;
        }

        private void cmbHesapTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlanlarıGuncelle();
        }

        // ── Hesap Oluştur butonu ──────────────────────────────────────
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = txtHesapSahibi.Text.Trim();
                if (string.IsNullOrWhiteSpace(ad))
                {
                    MessageBox.Show("Hesap sahibi adı boş olamaz.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tur = cmbHesapTuru.SelectedItem.ToString();

                if (tur == "Vadesiz Hesap")
                {
                    double bakiye = double.Parse(txtBakiye.Text);
                    YeniHesap = new VadesizHesap(ad, bakiye);
                }
                else if (tur == "Vadeli Hesap")
                {
                    double bakiye = double.Parse(txtBakiye.Text);
                    double faiz = double.Parse(txtFaizOrani.Text);
                    int vade = int.Parse(txtVadeGun.Text);
                    YeniHesap = new VadeliHesap(ad, bakiye, faiz, vade);
                }
                else if (tur == "Kredi Hesabı")
                {
                    double limit = double.Parse(txtKrediLimiti.Text);
                    double faiz = double.Parse(txtFaizOrani.Text);
                    YeniHesap = new KrediHesabi(ad, limit, faiz);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayısal alanlara geçerli bir değer girin.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── İptal butonu ──────────────────────────────────────────────
        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

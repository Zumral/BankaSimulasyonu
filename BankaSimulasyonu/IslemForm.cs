using BankaSimulasyonu.Interfaces;
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
    public partial class IslemForm : Form
    {
        private BankaHesabi _hesap;
        public IslemForm(BankaHesabi hesap)
        {
            InitializeComponent();
            _hesap = hesap;
            HesapBilgisiGoster();
            IslemGecmisiYukle();

            // Faiz butonu sadece IFaizHesapla uygulayan hesaplarda aktif
            btnFaizUygula.Enabled = _hesap is IFaizHesapla;
        }

        
        private void HesapBilgisiGoster()
        {
            lblHesapBilgi.Text =
                $"Hesap No     : {_hesap.HesapNo}\n" +
                $"Hesap Türü   : {_hesap.HesapTuru}\n" +
                $"Hesap Sahibi : {_hesap.HesapSahibi}\n" +
                $"Güncel Bakiye: {_hesap.Bakiye:C2}";
        }

       
        private void IslemGecmisiYukle()
        {
            lstIslemGecmisi.Items.Clear();
            foreach (var islem in _hesap.IslemGecmisi)
                lstIslemGecmisi.Items.Add(islem);
        }

        
        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            try
            {
                double miktar = double.Parse(txtMiktar.Text);
                bool sonuc = _hesap.ParaYatir(miktar);

                if (sonuc)
                {
                    MessageBox.Show($"✅ {miktar:C2} yatırıldı.", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HesapBilgisiGoster();
                    IslemGecmisiYukle();
                    txtMiktar.Clear();
                }
                else
                {
                    MessageBox.Show("Geçersiz miktar.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void btnParaCek_Click(object sender, EventArgs e)
        {
            try
            {
                double miktar = double.Parse(txtMiktar.Text);
                bool sonuc = _hesap.ParaCek(miktar);

                if (sonuc)
                {
                    MessageBox.Show($"✅ {miktar:C2} çekildi.", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HesapBilgisiGoster();
                    IslemGecmisiYukle();
                    txtMiktar.Clear();
                }
                else
                {
                    MessageBox.Show("Geçersiz miktar.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnFaizUygula_Click(object sender, EventArgs e)
        {
            try
            {
                if (_hesap is IFaizHesapla faizliHesap)
                {
                    double faiz = faizliHesap.FaizHesapla();
                    var onay = MessageBox.Show(
                        $"Uygulanacak faiz tutarı: {faiz:C2}\nDevam etmek istiyor musunuz?",
                        "Faiz Uygula", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (onay == DialogResult.Yes)
                    {
                        faizliHesap.FaizUygula();
                        MessageBox.Show($"✅ Faiz uygulandı: {faiz:C2}", "Başarılı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HesapBilgisiGoster();
                        IslemGecmisiYukle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

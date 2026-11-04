namespace BankaSimulasyonu
{
    partial class HesapAcForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtHesapSahibi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHesapTuru = new System.Windows.Forms.ComboBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.lblFaiz = new System.Windows.Forms.Label();
            this.txtFaizOrani = new System.Windows.Forms.TextBox();
            this.lblVade = new System.Windows.Forms.Label();
            this.txtVadeGun = new System.Windows.Forms.TextBox();
            this.lblKrediLimit = new System.Windows.Forms.Label();
            this.txtKrediLimiti = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap Sahibi Adı:";
            // 
            // txtHesapSahibi
            // 
            this.txtHesapSahibi.Location = new System.Drawing.Point(142, 6);
            this.txtHesapSahibi.Multiline = true;
            this.txtHesapSahibi.Name = "txtHesapSahibi";
            this.txtHesapSahibi.Size = new System.Drawing.Size(250, 23);
            this.txtHesapSahibi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hesap Türü:";
            // 
            // cmbHesapTuru
            // 
            this.cmbHesapTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHesapTuru.FormattingEnabled = true;
            this.cmbHesapTuru.Location = new System.Drawing.Point(142, 58);
            this.cmbHesapTuru.Name = "cmbHesapTuru";
            this.cmbHesapTuru.Size = new System.Drawing.Size(250, 24);
            this.cmbHesapTuru.TabIndex = 3;
            this.cmbHesapTuru.SelectedIndexChanged += new System.EventHandler(this.cmbHesapTuru_SelectedIndexChanged);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(9, 113);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(133, 16);
            this.lblBakiye.TabIndex = 4;
            this.lblBakiye.Text = "Başlangıç Bakiye (₺):";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(142, 110);
            this.txtBakiye.Multiline = true;
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(250, 23);
            this.txtBakiye.TabIndex = 5;
            // 
            // lblFaiz
            // 
            this.lblFaiz.AutoSize = true;
            this.lblFaiz.Location = new System.Drawing.Point(9, 165);
            this.lblFaiz.Name = "lblFaiz";
            this.lblFaiz.Size = new System.Drawing.Size(93, 16);
            this.lblFaiz.TabIndex = 6;
            this.lblFaiz.Text = "Faiz Oranı (%):";
            // 
            // txtFaizOrani
            // 
            this.txtFaizOrani.Location = new System.Drawing.Point(142, 162);
            this.txtFaizOrani.Multiline = true;
            this.txtFaizOrani.Name = "txtFaizOrani";
            this.txtFaizOrani.Size = new System.Drawing.Size(250, 23);
            this.txtFaizOrani.TabIndex = 7;
            // 
            // lblVade
            // 
            this.lblVade.AutoSize = true;
            this.lblVade.Location = new System.Drawing.Point(9, 217);
            this.lblVade.Name = "lblVade";
            this.lblVade.Size = new System.Drawing.Size(78, 16);
            this.lblVade.TabIndex = 8;
            this.lblVade.Text = "Vade (Gün):";
            // 
            // txtVadeGun
            // 
            this.txtVadeGun.Location = new System.Drawing.Point(142, 214);
            this.txtVadeGun.Multiline = true;
            this.txtVadeGun.Name = "txtVadeGun";
            this.txtVadeGun.Size = new System.Drawing.Size(250, 23);
            this.txtVadeGun.TabIndex = 9;
            // 
            // lblKrediLimit
            // 
            this.lblKrediLimit.AutoSize = true;
            this.lblKrediLimit.Location = new System.Drawing.Point(9, 269);
            this.lblKrediLimit.Name = "lblKrediLimit";
            this.lblKrediLimit.Size = new System.Drawing.Size(92, 16);
            this.lblKrediLimit.TabIndex = 10;
            this.lblKrediLimit.Text = "Kredi Limiti (₺):";
            // 
            // txtKrediLimiti
            // 
            this.txtKrediLimiti.Location = new System.Drawing.Point(142, 266);
            this.txtKrediLimiti.Multiline = true;
            this.txtKrediLimiti.Name = "txtKrediLimiti";
            this.txtKrediLimiti.Size = new System.Drawing.Size(250, 23);
            this.txtKrediLimiti.TabIndex = 11;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlustur.ForeColor = System.Drawing.Color.White;
            this.btnOlustur.Location = new System.Drawing.Point(23, 326);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(130, 35);
            this.btnOlustur.TabIndex = 12;
            this.btnOlustur.Text = "✅ Hesap Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Crimson;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(251, 326);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(130, 35);
            this.btnIptal.TabIndex = 13;
            this.btnIptal.Text = "❌ İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // HesapAcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 373);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.txtKrediLimiti);
            this.Controls.Add(this.lblKrediLimit);
            this.Controls.Add(this.txtVadeGun);
            this.Controls.Add(this.lblVade);
            this.Controls.Add(this.txtFaizOrani);
            this.Controls.Add(this.lblFaiz);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.cmbHesapTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHesapSahibi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HesapAcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Hesap Aç";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHesapSahibi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHesapTuru;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label lblFaiz;
        private System.Windows.Forms.TextBox txtFaizOrani;
        private System.Windows.Forms.Label lblVade;
        private System.Windows.Forms.TextBox txtVadeGun;
        private System.Windows.Forms.Label lblKrediLimit;
        private System.Windows.Forms.TextBox txtKrediLimiti;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnIptal;
    }
}
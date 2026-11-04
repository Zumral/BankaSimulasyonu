namespace BankaSimulasyonu
{
    partial class IslemForm
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
            this.pnlBilgi = new System.Windows.Forms.Panel();
            this.lblHesapBilgi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.btnFaizUygula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstIslemGecmisi = new System.Windows.Forms.ListBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.pnlBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBilgi
            // 
            this.pnlBilgi.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlBilgi.Controls.Add(this.lblHesapBilgi);
            this.pnlBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBilgi.Location = new System.Drawing.Point(0, 0);
            this.pnlBilgi.Name = "pnlBilgi";
            this.pnlBilgi.Size = new System.Drawing.Size(482, 100);
            this.pnlBilgi.TabIndex = 0;
            // 
            // lblHesapBilgi
            // 
            this.lblHesapBilgi.AutoSize = true;
            this.lblHesapBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHesapBilgi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapBilgi.Location = new System.Drawing.Point(0, 0);
            this.lblHesapBilgi.Name = "lblHesapBilgi";
            this.lblHesapBilgi.Size = new System.Drawing.Size(55, 23);
            this.lblHesapBilgi.TabIndex = 0;
            this.lblHesapBilgi.Text = "label1";
            this.lblHesapBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "İşlem Miktarı (₺):";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(153, 114);
            this.txtMiktar.Multiline = true;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(200, 23);
            this.txtMiktar.TabIndex = 2;
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnParaYatir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParaYatir.ForeColor = System.Drawing.Color.White;
            this.btnParaYatir.Location = new System.Drawing.Point(15, 175);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(130, 35);
            this.btnParaYatir.TabIndex = 3;
            this.btnParaYatir.Text = "⬆️ Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = false;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // btnParaCek
            // 
            this.btnParaCek.BackColor = System.Drawing.Color.DarkOrange;
            this.btnParaCek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParaCek.ForeColor = System.Drawing.Color.White;
            this.btnParaCek.Location = new System.Drawing.Point(170, 175);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(130, 35);
            this.btnParaCek.TabIndex = 4;
            this.btnParaCek.Text = "⬇️ Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = false;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // btnFaizUygula
            // 
            this.btnFaizUygula.BackColor = System.Drawing.Color.SlateBlue;
            this.btnFaizUygula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaizUygula.ForeColor = System.Drawing.Color.White;
            this.btnFaizUygula.Location = new System.Drawing.Point(325, 175);
            this.btnFaizUygula.Name = "btnFaizUygula";
            this.btnFaizUygula.Size = new System.Drawing.Size(130, 35);
            this.btnFaizUygula.TabIndex = 5;
            this.btnFaizUygula.Text = "💹 Faiz Uygula";
            this.btnFaizUygula.UseVisualStyleBackColor = false;
            this.btnFaizUygula.Click += new System.EventHandler(this.btnFaizUygula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "📋 İşlem Geçmişi:";
            // 
            // lstIslemGecmisi
            // 
            this.lstIslemGecmisi.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstIslemGecmisi.FormattingEnabled = true;
            this.lstIslemGecmisi.HorizontalScrollbar = true;
            this.lstIslemGecmisi.ItemHeight = 18;
            this.lstIslemGecmisi.Location = new System.Drawing.Point(15, 254);
            this.lstIslemGecmisi.Name = "lstIslemGecmisi";
            this.lstIslemGecmisi.Size = new System.Drawing.Size(440, 184);
            this.lstIslemGecmisi.TabIndex = 7;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.SlateGray;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(170, 456);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(130, 35);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "🚪 Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // IslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 503);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lstIslemGecmisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFaizUygula);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.pnlBilgi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IslemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hesap İşlemleri";
            this.pnlBilgi.ResumeLayout(false);
            this.pnlBilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBilgi;
        private System.Windows.Forms.Label lblHesapBilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Button btnFaizUygula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstIslemGecmisi;
        private System.Windows.Forms.Button btnKapat;
    }
}
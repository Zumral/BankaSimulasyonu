namespace BankaSimulasyonu
{
    partial class MainForm
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnHesapSil = new System.Windows.Forms.Button();
            this.btnIslemYap = new System.Windows.Forms.Button();
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.dgvHesaplar = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHesaplar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlUst.Controls.Add(this.btnRapor);
            this.pnlUst.Controls.Add(this.btnHesapSil);
            this.pnlUst.Controls.Add(this.btnIslemYap);
            this.pnlUst.Controls.Add(this.btnHesapAc);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(882, 60);
            this.pnlUst.TabIndex = 0;
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.ForeColor = System.Drawing.Color.White;
            this.btnRapor.Location = new System.Drawing.Point(738, 12);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(130, 35);
            this.btnRapor.TabIndex = 3;
            this.btnRapor.Text = "📋 Rapor Göster";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.BackColor = System.Drawing.Color.Crimson;
            this.btnHesapSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapSil.ForeColor = System.Drawing.Color.White;
            this.btnHesapSil.Location = new System.Drawing.Point(496, 12);
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.Size = new System.Drawing.Size(130, 35);
            this.btnHesapSil.TabIndex = 2;
            this.btnHesapSil.Text = "🗑️ Hesap Sil";
            this.btnHesapSil.UseVisualStyleBackColor = false;
            this.btnHesapSil.Click += new System.EventHandler(this.btnHesapSil_Click);
            // 
            // btnIslemYap
            // 
            this.btnIslemYap.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIslemYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslemYap.ForeColor = System.Drawing.Color.White;
            this.btnIslemYap.Location = new System.Drawing.Point(254, 12);
            this.btnIslemYap.Name = "btnIslemYap";
            this.btnIslemYap.Size = new System.Drawing.Size(130, 35);
            this.btnIslemYap.TabIndex = 1;
            this.btnIslemYap.Text = "💰 İşlem Yap";
            this.btnIslemYap.UseVisualStyleBackColor = false;
            this.btnIslemYap.Click += new System.EventHandler(this.btnIslemYap_Click);
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHesapAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapAc.ForeColor = System.Drawing.Color.White;
            this.btnHesapAc.Location = new System.Drawing.Point(12, 12);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(130, 35);
            this.btnHesapAc.TabIndex = 0;
            this.btnHesapAc.Text = "➕ Hesap Aç";
            this.btnHesapAc.UseVisualStyleBackColor = false;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // dgvHesaplar
            // 
            this.dgvHesaplar.AllowUserToAddRows = false;
            this.dgvHesaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHesaplar.BackgroundColor = System.Drawing.Color.White;
            this.dgvHesaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHesaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHesaplar.Location = new System.Drawing.Point(0, 60);
            this.dgvHesaplar.Name = "dgvHesaplar";
            this.dgvHesaplar.ReadOnly = true;
            this.dgvHesaplar.RowHeadersWidth = 51;
            this.dgvHesaplar.RowTemplate.Height = 24;
            this.dgvHesaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHesaplar.Size = new System.Drawing.Size(882, 493);
            this.dgvHesaplar.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDurum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDurum
            // 
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(457, 20);
            this.lblDurum.Text = "Hoş geldiniz! Yeni hesap açmak için ➕ Hesap Aç butonuna tıklayın.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvHesaplar);
            this.Controls.Add(this.pnlUst);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Hesap Yönetim Sistemi";
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHesaplar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnHesapSil;
        private System.Windows.Forms.Button btnIslemYap;
        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.DataGridView dgvHesaplar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDurum;
    }
}


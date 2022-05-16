
namespace ElekrikliAracKiralamaOtomasyonu
{
    partial class frmAlici
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAliciID = new System.Windows.Forms.TextBox();
            this.txtAliciAdi = new System.Windows.Forms.TextBox();
            this.txtAliciSoyadi = new System.Windows.Forms.TextBox();
            this.txtAliciAdres = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.dgwAliciListele = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAliciListele)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alıcı ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alıcı Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alıcı Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alıcı Adres";
            // 
            // txtAliciID
            // 
            this.txtAliciID.Location = new System.Drawing.Point(99, 38);
            this.txtAliciID.Name = "txtAliciID";
            this.txtAliciID.Size = new System.Drawing.Size(100, 20);
            this.txtAliciID.TabIndex = 1;
            // 
            // txtAliciAdi
            // 
            this.txtAliciAdi.Location = new System.Drawing.Point(99, 70);
            this.txtAliciAdi.Name = "txtAliciAdi";
            this.txtAliciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAliciAdi.TabIndex = 2;
            // 
            // txtAliciSoyadi
            // 
            this.txtAliciSoyadi.Location = new System.Drawing.Point(99, 101);
            this.txtAliciSoyadi.Name = "txtAliciSoyadi";
            this.txtAliciSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtAliciSoyadi.TabIndex = 3;
            // 
            // txtAliciAdres
            // 
            this.txtAliciAdres.Location = new System.Drawing.Point(99, 131);
            this.txtAliciAdres.Name = "txtAliciAdres";
            this.txtAliciAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAliciAdres.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(3, 231);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(123, 231);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(3, 293);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(207, 36);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(42, 23);
            this.btnBul.TabIndex = 7;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // dgwAliciListele
            // 
            this.dgwAliciListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAliciListele.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwAliciListele.Location = new System.Drawing.Point(297, 0);
            this.dgwAliciListele.Name = "dgwAliciListele";
            this.dgwAliciListele.Size = new System.Drawing.Size(811, 673);
            this.dgwAliciListele.TabIndex = 8;
            this.dgwAliciListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAliciListele_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alıcı Telefon";
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(99, 161);
            this.mtxtTel.Mask = "(999) 000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(100, 20);
            this.mtxtTel.TabIndex = 9;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(123, 293);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmAlici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElekrikliAracKiralamaOtomasyonu.Properties.Resources.Fırat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 673);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.mtxtTel);
            this.Controls.Add(this.dgwAliciListele);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAliciAdres);
            this.Controls.Add(this.txtAliciSoyadi);
            this.Controls.Add(this.txtAliciAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAliciID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmAlici";
            this.Text = "Alici";
            this.Load += new System.EventHandler(this.frmAlici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAliciListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAliciID;
        private System.Windows.Forms.TextBox txtAliciAdi;
        private System.Windows.Forms.TextBox txtAliciSoyadi;
        private System.Windows.Forms.TextBox txtAliciAdres;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.DataGridView dgwAliciListele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.Button btnTemizle;
    }
}
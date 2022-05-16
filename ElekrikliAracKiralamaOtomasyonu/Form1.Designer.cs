
namespace ElekrikliAracKiralamaOtomasyonu
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtalıcı = new System.Windows.Forms.Button();
            this.txtUrun = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ElekrikliAracKiralamaOtomasyonu.Properties.Resources.Fırat;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtalıcı);
            this.panel1.Controls.Add(this.txtUrun);
            this.panel1.Controls.Add(this.btnSiparis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 672);
            this.panel1.TabIndex = 0;
            // 
            // txtalıcı
            // 
            this.txtalıcı.BackColor = System.Drawing.Color.Aquamarine;
            this.txtalıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtalıcı.ForeColor = System.Drawing.Color.Crimson;
            this.txtalıcı.Location = new System.Drawing.Point(51, 502);
            this.txtalıcı.Name = "txtalıcı";
            this.txtalıcı.Size = new System.Drawing.Size(95, 51);
            this.txtalıcı.TabIndex = 0;
            this.txtalıcı.Text = "Alıcı İşlemleri";
            this.txtalıcı.UseVisualStyleBackColor = false;
            this.txtalıcı.Click += new System.EventHandler(this.txtalıcı_Click);
            // 
            // txtUrun
            // 
            this.txtUrun.BackColor = System.Drawing.Color.Aquamarine;
            this.txtUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrun.ForeColor = System.Drawing.Color.Crimson;
            this.txtUrun.Location = new System.Drawing.Point(51, 169);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(95, 51);
            this.txtUrun.TabIndex = 1;
            this.txtUrun.Text = "Ürün İşlemleri";
            this.txtUrun.UseVisualStyleBackColor = false;
            this.txtUrun.Click += new System.EventHandler(this.txtUrun_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparis.ForeColor = System.Drawing.Color.Crimson;
            this.btnSiparis.Location = new System.Drawing.Point(51, 304);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(95, 51);
            this.btnSiparis.TabIndex = 2;
            this.btnSiparis.Text = "Sipariş İşlemleri";
            this.btnSiparis.UseVisualStyleBackColor = false;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 672);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 672);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button txtUrun;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button txtalıcı;
    }
}


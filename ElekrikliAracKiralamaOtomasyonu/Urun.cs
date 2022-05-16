using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;


namespace ElekrikliAracKiralamaOtomasyonu
{
    public partial class frmUrun : Form
    {
       
        public frmUrun()
        {
            InitializeComponent();
        }
        BLL.BLL bll = new BLL.BLL();
        private void Urun_Load(object sender, EventArgs e)
        {
            UrunListem();
        }
        private void UrunListem()
        {
            dgwUrunListe.DataSource = bll.TumUrunler();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.UrunAdi = txtUrunAdi.Text;
            urun.UrunFiyat = decimal.Parse(txtFiyat.Text);
            urun.StokAdedi = int.Parse(txtStokAdedi.Text);
            bll.UrunEkle(urun);
            UrunListem();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtUrunID.Text);
            bll.UrunSil(id);
            UrunListem();
        }
        private void BtnBul_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
          urun.UrunID= Convert.ToInt32(txtUrunID.Text);
           var result= bll.UrunBul(urun.UrunID);
           

            if (urun.UrunID>0)
            {
                txtUrunID.Text = result.UrunID.ToString();
                txtUrunAdi.Text = result.UrunAdi;
           txtFiyat.Text = result.UrunFiyat.ToString();
                txtStokAdedi.Text = result.StokAdedi.ToString();

          }
            else
             MessageBox.Show("Aradığınız Ürün bulunamadı...");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.UrunID = Convert.ToInt32(txtUrunID.Text);
            urun.UrunAdi = txtUrunAdi.Text;
            urun.UrunFiyat = decimal.Parse(txtFiyat.Text);
            urun.StokAdedi = int.Parse(txtStokAdedi.Text);
            bll.UrunGüncelle(urun);
            UrunListem();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
                if (control is TextBox)
                    ((TextBox)control).Text = "";
        }
    }
}

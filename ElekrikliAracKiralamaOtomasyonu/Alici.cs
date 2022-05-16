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
namespace ElekrikliAracKiralamaOtomasyonu
{
    public partial class frmAlici : Form
    {
   
        public frmAlici()
        {
            InitializeComponent();
        }
        BLL.BLL bll = new BLL.BLL();
        private void frmAlici_Load(object sender, EventArgs e)
        {
            AliciListem();
        }

        private void AliciListem()
        {
            dgwAliciListele.DataSource = bll.TumAlicilar();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Alici alici = new Alici();
          
            alici.AliciAdi = txtAliciAdi.Text;
            alici.AliciSoyadi = txtAliciSoyadi.Text;
            alici.AliciAdresi = txtAliciAdres.Text;
            alici.AliciTelefonu = mtxtTel.Text;
            bll.AliciEkle(alici);
            AliciListem();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           int id= Convert.ToInt32(txtAliciID.Text);
            bll.AliciSil(id);
            AliciListem();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Alici alici = new Alici();
            alici.AliciID= Convert.ToInt32(txtAliciID.Text);
            alici.AliciAdi = txtAliciAdi.Text;
            alici.AliciSoyadi = txtAliciSoyadi.Text;
            alici.AliciAdresi = txtAliciAdres.Text;
            alici.AliciTelefonu = mtxtTel.Text;
            bll.AliciGüncelle(alici);
            AliciListem();
            
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Alici alici = new Alici();
            alici.AliciID = Convert.ToInt32(txtAliciID.Text);
            var result = bll.AliciBul(alici.AliciID);


            if (alici.AliciID > 0)
            {
                txtAliciID.Text = result.AliciID.ToString();
                txtAliciAdi.Text = result.AliciAdi;
                txtAliciSoyadi.Text = result.AliciSoyadi.ToString();
                txtAliciAdres.Text = result.AliciAdresi.ToString();
                mtxtTel.Text = result.AliciTelefonu.ToString();
             

            }
            else
                MessageBox.Show("Aradığınız Alıcı bulunamadı...");
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
                if (control is TextBox)
                    ((TextBox)control).Text = "";
        }

        private void dgwAliciListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtAliciID.Text=dgwAliciListele.
        }
    }
}

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
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }
        BLL.BLL bll = new BLL.BLL();

        private void Siparis_Load(object sender, EventArgs e)
        {
            SiparisListem();
            AliciDoldur();
            UrunDoldur();

        }

        private void SiparisListem()
        {
            dgwSiparisListele.DataSource = bll.TumSiparisler();

        }

        private void AliciDoldur()
        {
            comboBox1.DataSource = bll.TumAlicilar();
            comboBox1.DisplayMember = "AliciAdi";
            comboBox1.ValueMember = "AliciID";
        }
        private void UrunDoldur()
        {
            comboBox2.DataSource = bll.TumUrunler();
            comboBox2.DisplayMember = "UrunAdi";
            comboBox2.ValueMember = "UrunID";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            Alici alici = new Alici();
            string al_ad = (string)comboBox1.Text;
            txtAliciID.Text = bll.AliciAdiBul(al_ad).ToString();
            siparis.AliciID = Convert.ToInt32(txtAliciID.Text);
            
            string ur_ad = (string)comboBox2.Text;
            txtUrunID.Text = bll.UrunAdiBul(ur_ad).ToString();
            siparis.UrunID = Convert.ToInt32(txtUrunID.Text);
            siparis.SiparisAdet = Convert.ToInt32(txtSiparisAdet.Text);
            bll.SiparisEkle(siparis);
            SiparisListem();
        }

        private void dgwSiparisListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //s.SiparisID 1,a.AliciID 2,a.AliciAdi 3,a.AliciSoyadi 4,u.UrunID 5,u.UrunAdi 6,u.UrunFiyat 7,s.SiparisAdet 8
            txtSiparisID.Text = dgwSiparisListele.CurrentRow.Cells[0].Value.ToString();
            txtAliciID.Text = dgwSiparisListele.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dgwSiparisListele.CurrentRow.Cells[2].Value.ToString();
        txtUrunID.Text= dgwSiparisListele.CurrentRow.Cells[4].Value.ToString();
            comboBox2.Text = dgwSiparisListele.CurrentRow.Cells[5].Value.ToString();
            txtSiparisAdet.Text = dgwSiparisListele.CurrentRow.Cells[7].Value.ToString();
         
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtSiparisID.Text);
            bll.SiparisSil(id);
            SiparisListem();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Alici alici = new Alici();
            string al_ad = (string)comboBox1.Text;
            txtAliciID.Text = bll.AliciAdiBul(al_ad).ToString();
        

            string ur_ad = (string)comboBox2.Text;
            txtUrunID.Text = bll.UrunAdiBul(ur_ad).ToString();
        


            Siparis siparis = new Siparis();
            siparis.SiparisID = Convert.ToInt32(txtSiparisID.Text);
            siparis.AliciID = Convert.ToInt32(txtAliciID.Text);
            siparis.UrunID = Convert.ToInt32(txtUrunID.Text);
            siparis.SiparisAdet = Convert.ToInt32(txtSiparisAdet.Text);
            bll.SiparisGüncelle(siparis);
            SiparisListem();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
                if (control is TextBox)
                    ((TextBox)control).Text = "";
            
        }
    }
    }


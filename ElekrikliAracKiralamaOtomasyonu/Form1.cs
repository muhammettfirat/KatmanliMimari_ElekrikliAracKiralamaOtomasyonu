using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElekrikliAracKiralamaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
        public void PanelTemizle()
        {
            panel2.Controls.Clear();
        }
        private void txtUrun_Click(object sender, EventArgs e)
        {
            PanelTemizle();
            frmUrun formurun = new frmUrun();
            
            formurun.MdiParent = this;
          
            formurun.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(formurun);
            formurun.Show();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            PanelTemizle();
            frmSiparis frmSiparis = new frmSiparis();

            frmSiparis.MdiParent = this;

            frmSiparis.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frmSiparis);
            frmSiparis.Show();
        }

        private void txtalıcı_Click(object sender, EventArgs e)
        {
            PanelTemizle();
            frmAlici frmAlici = new frmAlici();


            frmAlici.MdiParent = this;

            frmAlici.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frmAlici);
            frmAlici.Show();
        }
    }
}

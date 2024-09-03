using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnEnun1_Click(object sender, EventArgs e)
        {
            FrmEnun1 frmEnun1 = new FrmEnun1();
            frmEnun1.Show();
            //awdawddd
        }

        private void BtnEnun2_Click(object sender, EventArgs e)
        {
            FrmEnun2 frmEnun2 = new FrmEnun2();
            frmEnun2.Show();
        }

        private void BtnEnun4_Click(object sender, EventArgs e)
        {
            FrmEnun4 frmEnun4 = new FrmEnun4();
            frmEnun4.Show();
        }

        private void BtnEnun6_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnun5_Click(object sender, EventArgs e)
        {
            FrmEnun5 frmEnun5 = new FrmEnun5();
            frmEnun5.Show();
        }
    }
}

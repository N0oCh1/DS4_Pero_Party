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

        private void BtnEnun3_Click(object sender, EventArgs e)
        {
            FrmEnun3 frmEnun3 = new FrmEnun3();
            frmEnun3.Show();
        }
    }
}

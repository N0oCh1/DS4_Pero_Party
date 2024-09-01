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
        }
    }
}

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
    public partial class FrmEnun4 : Form
    {
        public FrmEnun4()
        {
            InitializeComponent();
        }

        private void numNumero_ValueChanged(object sender, EventArgs e)
        {
            numNumero.Maximum = 9999;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            bool veredicto;
            decimal numP = numNumero.Value;
            DeterminarNumEnun4 determinar = new DeterminarNumEnun4();
            veredicto = determinar.NumPerfecto(numP);

            if (veredicto == true)
            {
                txtResultado.Text = (numP + " Es perfecto!!!");
            }
            else {
                txtResultado.Text = (numP + " no es perfecto!!!");
            }

        }
    }
}

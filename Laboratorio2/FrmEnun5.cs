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
    public partial class FrmEnun5 : Form
    {
        public FrmEnun5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtSalida.Items.Clear();
            int numero;
            if (int.TryParse(txtNum.Text, out numero))
            {
                while (numero > 1)
                {
                    //Numero Par.
                    if (numero % 2 == 0)
                    {
                        numero = numero / 2;
                        TxtSalida.Items.Add(numero);
                    }
                    //Numero Impar.
                    else if (numero % 2 == 1)
                    {
                        numero = 3 * numero + 1;
                        TxtSalida.Items.Add(numero);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número entero.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

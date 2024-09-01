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
    public partial class FrmEnun1 : Form
    {
        public FrmEnun1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (double.TryParse(TxtbCosto.Text, out total)) 
            {
                total = Convert.ToDouble(TxtbTotal.Text);
                CalculadoraEnun1 calculadora = new CalculadoraEnun1();
                TxtbGanancias.Text = Convert.ToString(calculadora.Ganancias(total));
                TxtbInpuesto.Text = Convert.ToString(calculadora.Impuesto(total));
            }
            else
            {
                MessageBox.Show("ingrese numeros", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

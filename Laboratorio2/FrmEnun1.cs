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
            double ganancias = 0, impuesto = 0;
            decimal total = 0;
            total = NumCosto.Value;
            CalculadoraEnun1 calculadora = new CalculadoraEnun1();
            ganancias = calculadora.Ganancias(total);
            impuesto = calculadora.Impuesto(total);
            TxtbGanancias.Text = Convert.ToString(ganancias);
            TxtbInpuesto.Text = Convert.ToString(impuesto);
            TxtbTotal.Text = Convert.ToString(ganancias+impuesto+total); 
        }
    }
}

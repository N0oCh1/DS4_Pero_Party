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
    public partial class FrmEnun3 : Form
    {
        public FrmEnun3()
        {
            InitializeComponent();
            NumEdad.Maximum = 150; NumEdad.Minimum = 1;
            NumGenero.Maximum = 2;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            List<CalcularEnun3> datos = new List<CalcularEnun3>();
            decimal edad = NumEdad.Value;
            decimal genero = NumGenero.Value;
            if(Convert.ToInt32(genero)== 0 ) 
            {
                LbRegistros.Items.Add($"{datos[1].edad} {datos[1].genero}");
                
            }
            else
            {
                LbRegistros.Items.Add("dato resgistrado");
                datos.Add(new CalcularEnun3(edad, genero));
                NumEdad.Value = 1;
                NumGenero.Value = 1;
            }
        }
    }
}

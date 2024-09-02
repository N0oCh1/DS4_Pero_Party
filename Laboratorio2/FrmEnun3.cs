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
        public List<decimal> Lgenero = new List<decimal>();
        public List<decimal> Ledad = new List<decimal>();
        public FrmEnun3()
        {
            InitializeComponent();
            NumEdad.Maximum = 150; NumEdad.Minimum = 1;
            NumGenero.Maximum = 2;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            decimal edad = NumEdad.Value;
            decimal genero = NumGenero.Value;
            decimal PHombre = 0, PMujer = 0;
            decimal 
            if (genero == 0) 
            {
                for(int i = 0; i < Lgenero.Count; i++)
                {

                }
                    LbRegistros.Items.Add($"{Ledad[i]} {Lgenero[i]}");
            }
            else
            {
                Ledad.Add(edad);
                Lgenero.Add(genero);
                LbRegistros.Items.Add("dato resgistrado");
                NumEdad.Value = 1;
                NumGenero.Value = 1;
            }
        }
    }
}

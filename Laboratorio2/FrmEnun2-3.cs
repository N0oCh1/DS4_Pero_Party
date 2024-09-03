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
    public partial class FrmEnun2 : Form
    {
        public List<decimal> Lgenero = new List<decimal>();
        public List<decimal> Ledad = new List<decimal>();
        public FrmEnun2()
        {
            InitializeComponent();
            NumEdad.Maximum = 150;
            NumGenero.Minimum = 0; NumGenero.Maximum = 2;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

  
        private void BtnCalcular_Click_1(object sender, EventArgs e)
        {
            decimal edad = NumEdad.Value;
            decimal genero = NumGenero.Value;
            decimal PHombre = 0, PMujer = 0, hombre=0, mujer=0;
            if (genero == 0)
            {
                for (int i = 0; i < Lgenero.Count; i++)
                {
                    LbRegistros.Items.Add($"{Ledad[i]} {Lgenero[i]}");
                    if (Ledad[i] >=40 && Lgenero[i].Equals(1))
                    {
                        PHombre++;
                    }
                    if(Ledad[i] >=18 && Ledad[i]<=25 && Lgenero[i].Equals(2))
                    {
                        PMujer++;
                    }
                    if(Lgenero[i].Equals(1))
                    {
                        hombre++;
                    }
                    if(Lgenero[i].Equals(2))
                    {
                       mujer++;
                    }
                }
                LbRegistros.Items.Add($"Cantidad de hombre: {hombre}");
                LbRegistros.Items.Add($"Mayores a 40 años: {Math.Round(PHombre/hombre * 100)} %");
                LbRegistros.Items.Add($"Cantidad de Mujeres: {mujer}");
                LbRegistros.Items.Add($"Entre 18 a 25 años: {Math.Round(PMujer/mujer*100)} %");

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

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
        public FrmEnun2()
        {
            InitializeComponent();
            NumEdad.Maximum = 150;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string genero;
            decimal edad;

            genero = TxtbGenero.Text;
            edad = NumEdad.Value;

            LbRegistros.Items.Add($"Genero: {genero} / Edad: {edad}");
            TxtbGenero.Clear();
            NumEdad.Value = 0;
        }
    }
}

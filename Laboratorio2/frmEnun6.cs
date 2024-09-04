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
    public partial class frmEnun6 : Form
    {
        public frmEnun6()
        {
            InitializeComponent();
        }

        private void lblNombre2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            imgCandidato1.BackgroundImage = Laboratorio2.Properties.Resources.Nefario;
            if(numVotos1.Value == 0 )
            {
                imgCandidato1.BackgroundImage = null;
            }
          

        }

        private void lblTitulo6_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
       


        }

        private void numVotos3_ValueChanged(object sender, EventArgs e)
        {
            imgCandidato3.BackgroundImage = Laboratorio2.Properties.Resources.Nefario;
            if (numVotos3.Value == 0)
            {
                imgCandidato3.BackgroundImage = null;
            }
        }

        private void numVotos2_ValueChanged(object sender, EventArgs e)
        {
            imgCandidato2.BackgroundImage = Laboratorio2.Properties.Resources.Nefario;
            if (numVotos2.Value == 0)
            {
                imgCandidato2.BackgroundImage = null;
            }
        }

        private void numVotos4_ValueChanged(object sender, EventArgs e)
        {
            imgCandidato4.BackgroundImage = Laboratorio2.Properties.Resources.Nefario;
            if (numVotos4.Value == 0)
            {
                imgCandidato4.BackgroundImage = null;
            }
        }

        private void numVotos1_ValueChanged(object sender, EventArgs e)
        {
            imgCandidato1.BackgroundImage = Laboratorio2.Properties.Resources.Nefario;
            if (numVotos1.Value == 0)
            {
                imgCandidato1.BackgroundImage = null;
            }
        }

        private void txtNombre2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResultados_Click_1(object sender, EventArgs e)
        {
            List<Candidato> votes = new List<Candidato>();

            votes.Add(new Candidato(txtNombre1.Text, numVotos1.Value));
            votes.Add(new Candidato(txtNombre2.Text, numVotos2.Value));
            votes.Add(new Candidato(txtNombre3.Text, numVotos3.Value));
            votes.Add(new Candidato(txtNombre4.Text, numVotos4.Value));

            var resultado = votes.OrderBy(flecha => flecha.Votos).ToList();
            resultado.Reverse();
            foreach (Candidato vote in resultado)
            {
                listResultado.Items.Add($"{vote.Nombre}{vote.Votos}");

            }
        }
    }
}

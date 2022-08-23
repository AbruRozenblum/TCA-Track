using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_1_Registro
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
            txtPrueba.Hide();
            txtMailU.Hide();
            txtNomE.Hide();
            txtMailE.Hide();
            txtDiagnostico.Hide();
            txtEdad.Hide();
            txtPronombre.Hide();
            txtActualC.Hide();
            txtNuevaC.Hide();
        }

        private void BtnPic_Click(object sender, EventArgs e)
        {

        }

        private void BtnIrInicio_Click_1(object sender, EventArgs e)
        {
            Inicio formaSiguiente = new Inicio();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void BtnMUsuario_Click(object sender, EventArgs e)
        {
            picMailU.Hide();
            txtMailU.Show();
        }

        private void BtnNUsuario_Click(object sender, EventArgs e)
        {
            picNombreU.Hide();
            txtPrueba.Show();
        }

        private void BtnNEspecialista_Click(object sender, EventArgs e)
        {
            picNomE.Hide();
            txtNomE.Show();
        }

        private void BtnMEspecialista_Click(object sender, EventArgs e)
        {
            picMailE.Hide();
            txtMailE.Show();
        }

        private void BtnDiagnostico_Click(object sender, EventArgs e)
        {
            picDiag.Hide();
            txtDiagnostico.Show();
        }

        private void BtnEdad_Click(object sender, EventArgs e)
        {
            picEdad.Hide();
            txtEdad.Show();
        }

        private void BtnPronombre_Click(object sender, EventArgs e)
        {
            picPronombre.Hide();
            txtPronombre.Show();
        }

        private void BtnActualC_Click(object sender, EventArgs e)
        {
            picActualC.Hide();
            txtActualC.Show();
        }

        private void BtnNuevaC_Click(object sender, EventArgs e)
        {
            picNuevaC.Hide();
            txtNuevaC.Show();
        }

        private void PicMailU_Click(object sender, EventArgs e)
        {

        }

        private void BtnImportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG |*.jpg";
            openFileDialog1.Title = "Foto de perfil";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string foto_perfil = openFileDialog1.FileName;
                pbFotoPerfil.Image = Image.FromFile(foto_perfil);
            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen");
            }
        }
    }
}

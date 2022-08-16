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
    public partial class Form1 : Form
    {
        string nombre;
        string mailusuario;
        string mailespecialista;
        string genero;
        string diagnostico;
        string contraseña;
        DateTime fecha;
        string usuario;
        string nombreespecialista;
        string pronombre;
            

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbDiagnostico.Items.Add("Anorexia");
            cmbDiagnostico.Items.Add("Bulimia");
            cmbDiagnostico.Items.Add("Obesidad");

        }

        private void CmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtMailDelUsuario.Text == "" || txtUsuario.Text == "" || cmbDiagnostico.SelectedIndex == -1 || txtContraseña.Text == "" || txtNombre.Text == "" || txtPronombre.Text == "")  

            {
                MessageBox.Show("Complete todos los campos para registrarse");
            }
            else if (rbtnFemenino == null && rbtnMasculino == null && rbtnOtro == null)
            {
                MessageBox.Show("Complete todos los campos para registrarse");
            }
            else if (rbtnOtro.Checked || rbtnMasculino.Checked || rbtnFemenino.Checked)
            {
                mailespecialista = txtMailEspecialista.Text;
                mailusuario = txtMailDelUsuario.Text;
                nombre = txtUsuario.Text;
                diagnostico = cmbDiagnostico.SelectedItem.ToString();
                fecha = dtFecha.Value;
                contraseña = txtContraseña.Text;
                nombreespecialista = txtNombreEspecialista.Text;
                pronombre = txtPronombre.Text;

                if (rbtnFemenino.Checked)
                {
                    
                    genero = "Femenino";
                }
                else if (rbtnMasculino.Checked)
                {
                    genero = "Masculino";
                }
                else if (rbtnOtro.Checked)
                {
                    genero = "Otro";
                }
                Inicio formaSiguiente = new Inicio();
                this.Hide(); //oculta la forma actual
                formaSiguiente.Show(); // muestra la forma2
            }
            else
            {
                MessageBox.Show("Complete todos los campos para registrarse");
            }
            
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void TxtMailDelUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            Log_In formaSiguiente = new Log_In();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}

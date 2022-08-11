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
        string mesnacimiento;
        int dia = 1;
        int dianacimiento;
        int año = 1942;
        int añonacimiento;
        string genero;
        string diagnostico;
        string contraseña;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (dia <= 31)
            {
                cmbDía.Items.Add(dia);
                dia++;
            }
            while (año <= 2012)
            {
                cmbAño.Items.Add(año);
                año++;
            }
            cmbMes.Items.Add("Enero");
            cmbMes.Items.Add("Febrero");
            cmbMes.Items.Add("Marzo");
            cmbMes.Items.Add("Abril");
            cmbMes.Items.Add("Mayo");
            cmbMes.Items.Add("Junio");
            cmbMes.Items.Add("Julio");
            cmbMes.Items.Add("Agosto");
            cmbMes.Items.Add("Septiembre");
            cmbMes.Items.Add("Octubre");
            cmbMes.Items.Add("Noviembre");
            cmbMes.Items.Add("Diciembre");

            cmbDiagnostico.Items.Add("Anorexia");
            cmbDiagnostico.Items.Add("Bulimia");
            cmbDiagnostico.Items.Add("Obesidad");
        }

        private void CmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtMailDelUsuario.Text == "" || txtMailEspecialista.Text == "" || txtNombre.Text == "" || cmbAño.SelectedIndex == -1 || cmbDiagnostico.SelectedIndex == -1 || cmbDía.SelectedIndex == -1 || cmbMes.SelectedIndex == -1)

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
                nombre = txtNombre.Text;
                dianacimiento = Convert.ToInt32(cmbDía.SelectedItem.ToString());
                añonacimiento = Convert.ToInt32(cmbAño.SelectedItem.ToString());
                mesnacimiento = cmbMes.SelectedItem.ToString();
                diagnostico = cmbDiagnostico.SelectedItem.ToString();

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
    }
}

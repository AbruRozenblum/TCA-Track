using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pantalla_1_Registro
{
    public partial class Form1 : Form
    {
        string nombre;
        string mailUsuario;
        string mailEspecialista;
        string genero;
        string diagnostico;
        string contraseña;
        DateTime fecha;
        string usuario;
        string nombreEspecialista;
        OleDbConnection dataBase;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbDiagnostico.Items.Add("Anorexia");
            cmbDiagnostico.Items.Add("Bulimia");
            cmbDiagnostico.Items.Add("Obesidad");
             /*
             * Creo la conexión
             */
            dataBase = new OleDbConnection();
            /*
             * Conecto con la base de datos
             */
            dataBase.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";


        }


        private void CmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtMailDelUsuario.Text == "" || txtUsuario.Text == "" || cmbDiagnostico.SelectedIndex == -1 || txtContraseña.Text == "" || txtNombre.Text == "")  

            {
                MessageBox.Show("Complete todos los campos para registrarse");
            }
            else if (rbtnFemenino == null && rbtnMasculino == null && rbtnOtro == null)
            {
                MessageBox.Show("Complete todos los campos para registrarse");
            }
            else if (rbtnOtro.Checked || rbtnMasculino.Checked || rbtnFemenino.Checked)
            {
                nombre = txtNombre.Text;
                mailEspecialista = txtMailEspecialista.Text;
                mailUsuario = txtMailDelUsuario.Text;
                usuario = txtUsuario.Text;
                diagnostico = cmbDiagnostico.SelectedItem.ToString();
                fecha = dtFecha.Value;
                contraseña = txtContraseña.Text;
                nombreEspecialista = txtNombreEspecialista.Text;

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

                dataBase.Open();
                
                OleDbCommand agregoInfoUser;
                agregoInfoUser = new OleDbCommand("INSERT INTO Info_usuario (Username, Nombre_completo, Mail, Contraseña, Diagnostico, Fecha_nacimiento, Género, Mail_especialista) VALUES ('" + usuario + "', '" + nombre + "', '" + mailUsuario + "','" + contraseña + "', '" + diagnostico + "', '" + fecha + "', '" + genero + "', '" + mailEspecialista + "');");
                agregoInfoUser.Connection = dataBase;
                agregoInfoUser.ExecuteNonQuery();

                OleDbCommand buscoInfoEspecialista;
                buscoInfoEspecialista = new OleDbCommand("SELECT  * FROM Info_especialista WHERE Mail = '" + mailEspecialista + "';");
                buscoInfoEspecialista.Connection = dataBase;
                buscoInfoEspecialista.ExecuteNonQuery();
                if (buscoInfoEspecialista == null)
                {
                    /*
                     *declaro el objeto de mi comando
                     */
                    OleDbCommand agregoInfoEspecialista;
                    /*
                     * asigno la funcion del comando
                     */
                    agregoInfoEspecialista = new OleDbCommand("INSERT INTO Info_especialista (Nombre, Mail) VALUES ('" + nombreEspecialista + "', '" + mailEspecialista + "');");
                    /*
                     * asigno el comando a la base de datos sobre la que lo voy a ejecutar
                     */
                    agregoInfoEspecialista.Connection = dataBase;
                    /*
                     * ejecuto el comando
                     */
                    agregoInfoEspecialista.ExecuteNonQuery();
                }
                else
                {

                }

                dataBase.Close();



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

        private void PictureBox16_Click(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pantalla_1_Registro
{
    public partial class Form1 : Form
    {
        string genero;
        OleDbConnection dataBase;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cmbDiagnostico.Items.Add("Anorexia nerviosa");
            cmbDiagnostico.Items.Add("Bulimia nerviosa");
            cmbDiagnostico.Items.Add("Trastorno por atracon");
            cmbDiagnostico.Items.Add("Vigorexia");
            cmbDiagnostico.Items.Add("Ortorexia");
            cmbDiagnostico.Items.Add("Otro");

            // Creo la conexión
            dataBase = new OleDbConnection();
            /*
             * Conecto con la base de datos
             */
            dataBase.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
            dtFecha.MaxDate = DateTime.Now;
            dtFecha.Value = DateTime.Today;

            txtContraseña.MaxLength = 14;
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
                dataBase.Open();
                OleDbCommand userExistente;
                userExistente = new OleDbCommand("SELECT * FROM Info_usuario WHERE Username = '" + txtUsuario.Text + "'", dataBase);
                OleDbDataAdapter adapter1 = new OleDbDataAdapter(userExistente);
                DataSet dataset1 = new DataSet();
                adapter1.Fill(dataset1);
                OleDbCommand mailUsado;
                mailUsado = new OleDbCommand("SELECT * FROM Info_usuario WHERE mail = '" + txtMailDelUsuario.Text + "'", dataBase);
                OleDbDataAdapter adapter2 = new OleDbDataAdapter(mailUsado);
                DataSet dataset2 = new DataSet();
                adapter2.Fill(dataset2);
                if (dataset1.Tables[0].Rows.Count == 0 && dataset2.Tables[0].Rows.Count == 0)
                {
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

                    if ((txtMailEspecialista.Text!="" && txtNombreEspecialista.Text == "") || (txtNombre.Text != "" && txtMailEspecialista.Text == ""))
                    {
                        MessageBox.Show("Ingrese el nombre o el mail del especialista");
                    }
                    else if (txtMailEspecialista.Text!="" && txtNombreEspecialista.Text != "")
                    {
                        OleDbCommand agregoInfoUser;
                        agregoInfoUser = new OleDbCommand("INSERT INTO Info_usuario (Nombre_completo, Username, Mail, Contraseña, Diagnostico, Fecha_nacimiento, Género, Mail_especialista) VALUES ('" + txtUsuario.Text + "', '" + txtNombre.Text + "', '" + txtMailDelUsuario.Text + "','" + txtContraseña.Text + "', '" + cmbDiagnostico.SelectedItem + "', '" + dtFecha.Value + "', '" + genero + "', '" + txtMailEspecialista.Text + "');");
                        agregoInfoUser.Connection = dataBase;
                        agregoInfoUser.ExecuteNonQuery();

                        OleDbCommand buscoInfoEspecialista;
                        buscoInfoEspecialista = new OleDbCommand("SELECT  * FROM Info_especialista WHERE Mail = '" + txtMailEspecialista.Text + "'", dataBase);
                        OleDbDataAdapter adapter = new OleDbDataAdapter(buscoInfoEspecialista);
                        DataSet dataset = new DataSet();
                        adapter.Fill(dataset);

                        if (dataset.Tables[0].Rows.Count == 0)
                        {
                            /*
                             *declaro el objeto de mi comando
                             */
                            OleDbCommand agregoInfoEspecialista;
                            /*
                             * asigno la funcion del comando
                             */
                            agregoInfoEspecialista = new OleDbCommand("INSERT INTO Info_especialista (Nombre, Mail) VALUES ('" + txtNombreEspecialista.Text + "', '" + txtMailEspecialista.Text + "')");
                            /*
                             * asigno el comando a la base de datos sobre la que lo voy a ejecutar
                             */
                            agregoInfoEspecialista.Connection = dataBase;

                            // ejecuto el comando

                            agregoInfoEspecialista.ExecuteNonQuery();
                        }
                        Inicio formaSiguiente = new Inicio();
                        this.Hide(); //oculta la forma actual
                        formaSiguiente.Show(); // muestra la forma2
                    }

                    else
                    {
                        OleDbCommand agregoInfoUser;
                        agregoInfoUser = new OleDbCommand("INSERT INTO Info_usuario (Username, Nombre_completo, Mail, Contraseña, Diagnostico, Fecha_nacimiento, Género) VALUES ('" + txtUsuario.Text + "', '" + txtNombre.Text + "', '" + txtMailDelUsuario.Text + "','" + txtContraseña.Text + "', '" + cmbDiagnostico.SelectedItem + "', '" + dtFecha + "', '" + genero + "');");
                        agregoInfoUser.Connection = dataBase;
                        agregoInfoUser.ExecuteNonQuery();

                        Inicio formaSiguiente = new Inicio();
                        this.Hide(); //oculta la forma actual
                        formaSiguiente.Show(); // muestra la forma2
                    }
                    

                    dataBase.Close();
                }
                else if (dataset2.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("El mail ingresado ya fue utilizado por otro usuario");
                }
                else if (dataset1.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("El nombre de usuario ya fue utilizado");
                }
            }


            else
            {
                MessageBox.Show("Complete todos los campos para registrarse");
            }

        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            Log_In formaSiguiente = new Log_In();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }
    }
}

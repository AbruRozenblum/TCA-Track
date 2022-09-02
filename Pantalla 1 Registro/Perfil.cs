﻿using System;
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
    public partial class Perfil : Form
    {
        OleDbConnection dataBase;
        string nombreCompleto;
        string username;
        string contraseña;
        string mail;
        string diagnostico;
        string fechaNacimiento;
        string genero;
        string mailEspecialista;

        public Perfil()
        {
            InitializeComponent();
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
        }

        private void BtnNUsuario_Click(object sender, EventArgs e)
        {
        }

        private void BtnNEspecialista_Click(object sender, EventArgs e)
        {
        }

        private void BtnMEspecialista_Click(object sender, EventArgs e)
        {
        }

        private void BtnDiagnostico_Click(object sender, EventArgs e)
        {
        }

        private void BtnEdad_Click(object sender, EventArgs e)
        {
        }

        private void BtnPronombre_Click(object sender, EventArgs e)
        {
        }

        private void BtnActualC_Click(object sender, EventArgs e)
        {
        }

        private void BtnNuevaC_Click(object sender, EventArgs e)
        {
        }

        private void PicMailU_Click(object sender, EventArgs e)
        {

        }

        private void BtnImportar_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "JPG |*.jpg";
            ofd1.Title = "Foto de perfil";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                string foto_perfil = ofd1.FileName;
                pbFotoPerfil.Image = Image.FromFile(foto_perfil);
            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            dataBase = new OleDbConnection();
            dataBase.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";

            dataBase.Open();
            OleDbCommand diagnostico;
            diagnostico = new OleDbCommand("SELECT  Diagnostico FROM Info_usuario WHERE Mail = 'mail';");
            diagnostico.Connection = dataBase;
            diagnostico.ExecuteNonQuery();

            txtDiagnostico.Text = "Diagnostico";
            txtEdad.Text = "Edad";
            txtMailE.Text = "Mail Especialista";
            txtMailU.Text = "Mail Usuario";
            txtNomE.Text = "Nombre Especialista";
            txtNuevaC.Text = "Nueva contraseña";
            txtPronombre.Text = "Pronombre";
            txtActualC.Text = "Actual contraseña";

        }

        private void txtMailU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



/*UPDATE Info_usuario
SET Username = 'variable', Nombre_completo= 'variable'
WHERE ID = ...;*/
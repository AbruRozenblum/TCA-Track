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
    public partial class Perfil : Form
    {
        OleDbConnection dataBase;

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
            OleDbCommand commandD;
            commandD = new OleDbCommand("SELECT  Diagnostico FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandD.ExecuteNonQuery();
            OleDbDataAdapter adapterD = new OleDbDataAdapter(commandD);
            DataSet datasetD = new DataSet();
            adapterD.Fill(datasetD);

            OleDbCommand commandMe;
            commandMe = new OleDbCommand("SELECT Mail_especialista FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandMe.ExecuteNonQuery();
            OleDbDataAdapter adapterMe = new OleDbDataAdapter(commandMe);
            DataSet datasetMe = new DataSet();
            adapterMe.Fill(datasetMe);

            OleDbCommand commandM;
            commandM = new OleDbCommand("SELECT Mail FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandM.ExecuteNonQuery();
            OleDbDataAdapter adapterM = new OleDbDataAdapter(commandM);
            DataSet datasetM = new DataSet();
            adapterM.Fill(datasetM);

            OleDbCommand commandNe;
            commandNe = new OleDbCommand("SELECT Nombre FROM Info_especialista WHERE Mail = '" + datasetMe.Tables[0].Rows[0][0].ToString() + "';", dataBase);
            commandNe.ExecuteNonQuery();
            OleDbDataAdapter adapterNe = new OleDbDataAdapter(commandNe);
            DataSet datasetNe = new DataSet();
            adapterM.Fill(datasetNe);

            txtDiagnostico.Text = datasetD.Tables[0].Rows[0][0].ToString();
            txtMailE.Text = datasetMe.Tables[0].Rows[0][0].ToString();
            txtMailU.Text = datasetM.Tables[0].Rows[0][0].ToString();
            txtNomE.Text = datasetNe.Tables[0].Rows[0][0].ToString();
            txtNuevaC.Text = "Nueva contraseña";
            txtActualC.Text = "Actual contraseña";
            txtPrueba.Text = Class1.username;

            /*OleDbCommand commandC;
            commandC = new OleDbCommand("SELECT Contraseña FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandC.ExecuteNonQuery();
            OleDbDataAdapter adapterC = new OleDbDataAdapter(commandC);
            DataSet datasetC = new DataSet();
            adapterC.Fill(datasetC);*/
        }

        private void txtMailU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



/*UPDATE Info_usuario
SET Username = 'variable', Nombre_completo= 'variable'
WHERE ID = ...;*/
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Pantalla_1_Registro
{
    public partial class Perfil : Form
    {
        OleDbConnection dataBase;

        public Perfil()
        {
            InitializeComponent();
        }


        private void BtnIrInicio_Click_1(object sender, EventArgs e)
        {
            Inicio formaSiguiente = new Inicio();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void BtnMUsuario_Click(object sender, EventArgs e)
        {
            dataBase.Open();
            OleDbCommand mailU;
            mailU = new OleDbCommand("UPDATE Info_usuario SET Mail = '" + txtMailU.Text + "' WHERE Username = '" + Class1.username + "'");
            mailU.Connection = dataBase;
            mailU.ExecuteNonQuery();
            dataBase.Close();
            MessageBox.Show("Se actualizó el mail del usuario");
        }

        private void BtnNUsuario_Click(object sender, EventArgs e)
        {
            dataBase.Open();
            OleDbCommand nombreU;
            nombreU = new OleDbCommand("UPDATE Info_usuario SET Username = '" + txtPrueba.Text + "' WHERE Username = '" + Class1.username + "'");
            nombreU.Connection = dataBase;
            nombreU.ExecuteNonQuery();

            OleDbCommand diario;
            diario = new OleDbCommand("UPDATE Diario SET Username = '" + txtPrueba.Text + "' WHERE Username = '" + Class1.username + "'");
            diario.Connection = dataBase;
            diario.ExecuteNonQuery();

            OleDbCommand calendario;
            calendario = new OleDbCommand("UPDATE Calendario SET Username = '" + txtPrueba.Text + "' WHERE Username = '" + Class1.username + "'");
            calendario.Connection = dataBase;
            calendario.ExecuteNonQuery();

            Class1.username = txtPrueba.Text;
            dataBase.Close();
            MessageBox.Show("Se actualizó el nombre de usuario");
        }

        private void BtnNEspecialista_Click(object sender, EventArgs e)
        {
            dataBase.Open();
            OleDbCommand commandMe;
            commandMe = new OleDbCommand("SELECT Mail_especialista FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandMe.ExecuteNonQuery();
            OleDbDataAdapter adapterMe = new OleDbDataAdapter(commandMe);
            DataSet datasetMe = new DataSet();
            adapterMe.Fill(datasetMe);


            OleDbCommand nEspecialista;
            nEspecialista = new OleDbCommand("UPDATE Info_especialista SET Nombre = '" + txtNomE.Text + "' WHERE Mail = '" + datasetMe.Tables[0].Rows[0][0].ToString() + "'");
            nEspecialista.Connection = dataBase;
            nEspecialista.ExecuteNonQuery();
            dataBase.Close();

            MessageBox.Show("Se actualizó el nombre del especialista");
        }

        private void BtnMEspecialista_Click(object sender, EventArgs e)
        {
            dataBase.Open();
            OleDbCommand commandMe;
            commandMe = new OleDbCommand("SELECT Mail_especialista FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandMe.ExecuteNonQuery();
            OleDbDataAdapter adapterMe = new OleDbDataAdapter(commandMe);
            DataSet datasetMe = new DataSet();
            adapterMe.Fill(datasetMe);

            OleDbCommand mEspecialista;
            mEspecialista = new OleDbCommand("UPDATE Info_usuario SET Mail_especialista = '" + txtMailE.Text + "' WHERE Username = '" + Class1.username + "'");
            mEspecialista.Connection = dataBase;
            mEspecialista.ExecuteNonQuery();

            OleDbCommand mEspecialista2;
            mEspecialista2 = new OleDbCommand("UPDATE Info_especialista SET Mail = '" + txtMailE.Text + "' WHERE Mail = '" + datasetMe.Tables[0].Rows[0][0].ToString() + "'");
            mEspecialista2.Connection = dataBase;
            mEspecialista2.ExecuteNonQuery();
            dataBase.Close();

            MessageBox.Show("Se actualizó el nombre del especialista");
        }

        private void BtnDiagnostico_Click(object sender, EventArgs e)
        {
            dataBase.Open();
            OleDbCommand fNacimiento;
            fNacimiento = new OleDbCommand("UPDATE Info_usuario SET Diagnostico = '" + cmbDiagnostico.SelectedItem + "' WHERE Username = '" + Class1.username + "'");
            fNacimiento.Connection = dataBase;
            fNacimiento.ExecuteNonQuery();
            dataBase.Close();
            MessageBox.Show("Se actualizó el diagnostico");
        }

        private void BtnEdad_Click(object sender, EventArgs e)
        {
            dataBase.Open();
            OleDbCommand fNacimiento;
            fNacimiento = new OleDbCommand("UPDATE Info_usuario SET Fecha_nacimiento = '" + dtfnacimiento.Value + "' WHERE Username = '" + Class1.username + "'");
            fNacimiento.Connection = dataBase;
            fNacimiento.ExecuteNonQuery();
            dataBase.Close();
            MessageBox.Show("Se actualizó la fecha de nacimiento");
        }

        private void BtnNyA_Click(object sender, EventArgs e)
        {
            dataBase.Open();
            OleDbCommand fNacimiento;
            fNacimiento = new OleDbCommand("UPDATE Info_usuario SET Nombre_completo = '" + txtNyA.Text + "' WHERE Username = '" + Class1.username + "'");
            fNacimiento.Connection = dataBase;
            fNacimiento.ExecuteNonQuery();
            dataBase.Close();
            MessageBox.Show("Se actualizó el nombre completo");
        }

        private void BtnNuevaC_Click(object sender, EventArgs e)
        {
            dataBase.Open();
            OleDbCommand commandC;
            commandC = new OleDbCommand("SELECT * FROM Info_usuario WHERE Username = '" + Class1.username + "' AND Contraseña = '" + txtActualC.Text + "';", dataBase);
            OleDbDataAdapter adapterC = new OleDbDataAdapter(commandC);
            DataSet datasetC = new DataSet();
            adapterC.Fill(datasetC);
            if (datasetC.Tables[0].Rows.Count != 0)
            {
                OleDbCommand commandU;
                commandU = new OleDbCommand("UPDATE Info_usuario SET Contraseña = '" + txtNuevaC.Text + "' WHERE Username = '" + Class1.username + "'", dataBase);
                commandU.ExecuteNonQuery();
                MessageBox.Show("Se actualizó la contraseña");
                txtActualC.Text = "";
                txtNuevaC.Text = "";
            }
            else
            {
                MessageBox.Show("La contraseña ingresada es incorrecta, para actualizarla debe ingresar la contraseña actual");
            }
            dataBase.Close();
        }

        private void BtnImportar_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "JPG |*.jpg";
            ofd1.Title = "Foto de perfil";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                string foto_perfil = ofd1.FileName;
                Console.WriteLine(foto_perfil);
                pbFotoPerfil.Image = Image.FromFile(foto_perfil);
                dataBase.Open();
                OleDbCommand foto = new OleDbCommand("UPDATE Info_usuario SET Foto_perfil = '" + foto_perfil + "' WHERE Username = '" + Class1.username + "'");
                foto.Connection = dataBase;
                foto.ExecuteNonQuery();
                dataBase.Close();
            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen");
            }

        }


        private void Perfil_Load(object sender, EventArgs e)
        {
            cmbDiagnostico.Items.Add("Anorexia nerviosa");
            cmbDiagnostico.Items.Add("Bulimia nerviosa");
            cmbDiagnostico.Items.Add("Trastorno por atracon");
            cmbDiagnostico.Items.Add("Vigorexia");
            cmbDiagnostico.Items.Add("Ortorexia");
            cmbDiagnostico.Items.Add("Otro");


            dataBase = new OleDbConnection();
            dataBase.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";

            dataBase.Open();
            OleDbCommand commandD;
            commandD = new OleDbCommand("SELECT Diagnostico FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandD.ExecuteNonQuery();
            OleDbDataAdapter adapterD = new OleDbDataAdapter(commandD);
            DataSet datasetD = new DataSet();
            adapterD.Fill(datasetD);

            OleDbCommand commandM;
            commandM = new OleDbCommand("SELECT Mail FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandM.ExecuteNonQuery();
            OleDbDataAdapter adapterM = new OleDbDataAdapter(commandM);
            DataSet datasetM = new DataSet();
            adapterM.Fill(datasetM);

            OleDbCommand commandMe;
            commandMe = new OleDbCommand("SELECT Mail_especialista FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandMe.ExecuteNonQuery();
            OleDbDataAdapter adapterMe = new OleDbDataAdapter(commandMe);
            DataSet datasetMe = new DataSet();
            adapterMe.Fill(datasetMe);

            OleDbCommand commandNe;
            commandNe = new OleDbCommand("SELECT Nombre FROM Info_especialista WHERE Mail = '" + datasetMe.Tables[0].Rows[0][0].ToString() + "';", dataBase);
            commandNe.ExecuteNonQuery();
            OleDbDataAdapter adapterNe = new OleDbDataAdapter(commandNe);
            DataSet datasetNe = new DataSet();
            adapterNe.Fill(datasetNe);

            OleDbCommand commandF;
            commandF = new OleDbCommand("SELECT Fecha_nacimiento FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandF.ExecuteNonQuery();
            OleDbDataAdapter adapterF = new OleDbDataAdapter(commandF);
            DataSet datasetF = new DataSet();
            adapterF.Fill(datasetF);

            OleDbCommand commandN;
            commandN = new OleDbCommand("SELECT Nombre_completo FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandN.ExecuteNonQuery();
            OleDbDataAdapter adapterN = new OleDbDataAdapter(commandN);
            DataSet datasetN = new DataSet();
            adapterN.Fill(datasetN);

            cmbDiagnostico.SelectedItem = datasetD.Tables[0].Rows[0][0].ToString();
            txtMailE.Text = datasetMe.Tables[0].Rows[0][0].ToString();
            txtMailU.Text = datasetM.Tables[0].Rows[0][0].ToString();
            txtNomE.Text = datasetNe.Tables[0].Rows[0][0].ToString();
            txtNyA.Text = datasetN.Tables[0].Rows[0][0].ToString();
            txtPrueba.Text = Class1.username;
            txtActualC.MaxLength = 14;
            txtNuevaC.MaxLength = 14;
            dtfnacimiento.MaxDate = DateTime.Now;
            dtfnacimiento.Value = DateTime.Parse(datasetF.Tables[0].Rows[0][0].ToString());
            OleDbCommand commandC;
            commandC = new OleDbCommand("SELECT Contraseña FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandC.ExecuteNonQuery();
            OleDbDataAdapter adapterC = new OleDbDataAdapter(commandC);
            DataSet datasetC = new DataSet();
            adapterC.Fill(datasetC);

            OleDbCommand commandI;
            commandI = new OleDbCommand("SELECT Foto_perfil FROM Info_usuario WHERE Username = '" + Class1.username + "';", dataBase);
            commandI.ExecuteNonQuery();
            OleDbDataAdapter adapterI = new OleDbDataAdapter(commandI);
            DataSet datasetI = new DataSet();
            adapterI.Fill(datasetI);
            if (datasetI.Tables[0].Rows[0][0].ToString() != "")
            {
                pbFotoPerfil.ImageLocation = datasetI.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                pbFotoPerfil.Image = Pantalla_1_Registro.Properties.Resources.profile_pic;
            }
            this.pbFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            dataBase.Close();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Bienvenido formaSiguiente = new Bienvenido();
            this.Hide(); 
            formaSiguiente.Show(); 
        }
    }
}
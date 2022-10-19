using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pantalla_1_Registro
{

    public partial class Log_In : Form
    {
        OleDbConnection dataBase;

        public Log_In()
        {
            InitializeComponent();
        }

        private void Button1_Click /* BOTON DE INICIO DE SESION*/(object sender, EventArgs e)
        {

            dataBase.Open();
            OleDbCommand verificoLogIn;
            verificoLogIn = new OleDbCommand("SELECT * FROM Info_usuario WHERE Username = '" + txtusername.Text + "' and Contraseña = '" + txtcontraseña.Text + "'", dataBase);
            OleDbDataAdapter adapter = new OleDbDataAdapter(verificoLogIn);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            if (dataset.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Usuario y/o contraseña ingresado incorrecto");
            }
            else
            {
                Class1.username = txtusername.Text;
                Inicio formaSiguiente = new Inicio();
                this.Hide();
                formaSiguiente.Show();
            }
            dataBase.Close();
            //no tocar, estoy intentando confgurar el log in
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 formaSiguiente = new Form1();
            this.Hide();
            formaSiguiente.Show();
        }

        private void Log_In_Load(object sender, EventArgs e)
        {
            dataBase = new OleDbConnection();
            dataBase.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
            txtcontraseña.Text = "";
            txtcontraseña.PasswordChar = '*';
            txtcontraseña.MaxLength = 14;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtcontraseña.UseSystemPasswordChar = true;
            }
            else 
            {
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

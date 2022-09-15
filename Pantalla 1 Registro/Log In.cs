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

    public partial class Log_In : Form
    {
        OleDbConnection dataBase;

        public Log_In()
        {
            InitializeComponent();
        }

        private void Button1_Click /* BOTON DE INICIO DE SESION*/(object sender, EventArgs e)
        {

            //dataBase.Open();
            //OleDbCommand verificoLogIn;
            //verificoLogIn = new OleDbCommand("SELECT * FROM Info_usuario WHERE Username = '" + txtusername.Text + "' and Contraseña = '" + txtcontraseña.Text + "'", dataBase);
            //OleDbDataAdapter adapter = new OleDbDataAdapter (verificoLogIn);
            //DataSet dataset = new DataSet();
            //adapter.Fill(dataset);
            //if (dataset.Tables[0].Rows.Count != 0)
            {
                Class1.username = txtusername.Text;
                Inicio formaSiguiente = new Inicio();
                this.Hide(); //oculta la forma actual
                formaSiguiente.Show(); // muestra la forma

            }
            //else
            {
                //MessageBox.Show("Usuario y/o contraseña ingresado incorrecto");
            }
            //dataBase.Close();
            //no tocar, estoy intentando confgurar el log in


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            


            Form1 formaSiguiente = new Form1();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Log_In_Load(object sender, EventArgs e)
        {
            dataBase = new OleDbConnection();
            dataBase.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
            txtcontraseña.Text = "";
            txtcontraseña.PasswordChar = '*';
            txtcontraseña.MaxLength = 14;
        }

    }
}

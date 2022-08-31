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
        OleDbConnection inicioSesion;

        public Log_In()
        {
            InitializeComponent();
        }

        private void Button1_Click /* BOTON DE INICIO DE SESION*/(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string contraseña = txtcontraseña.Text;

            /*inicioSesion.Open();
            OleDbCommand verificoLogIn;
            verificoLogIn = new OleDbCommand();
            verificoLogIn.Connection = inicioSesion;
            verificoLogIn.ExecuteNonQuery();
            verificoLogIn.Close();*/
            //no tocar, estoy intentando confgurar el log in

            Inicio formaSiguiente = new Inicio();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma
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
            inicioSesion = new OleDbConnection();
            inicioSesion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
        }
    }
}

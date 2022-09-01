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
    public partial class Diario : Form
    {
        OleDbConnection db;
        public Diario()
        {
            InitializeComponent();
        }

        private void BtnIrInicio_Click(object sender, EventArgs e)
        {
            Inicio formaSiguiente = new Inicio();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void Diario_Load(object sender, EventArgs e)
        {
            db = new OleDbConnection();
            db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtTexto == null)
            {
                MessageBox.Show("No hay ningun texto registrado");
            }
            else
            {
                DateTime Fecha = dtfecha.Value;
                string testimonio = txtTexto.Text;
                db.Open();

                OleDbCommand AgregarTestimonio;
                AgregarTestimonio = new OleDbCommand("INSERT INTO Diario (Testimonio, Fecha) VALUES ('" + testimonio + "', '" + Fecha + "');");
                AgregarTestimonio.Connection = db;
                AgregarTestimonio.ExecuteNonQuery();
            }
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

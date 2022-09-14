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
            db.Open();
            DateTime fecha = dtfecha.Value;
            OleDbCommand commandF;
            commandF = new OleDbCommand("SELECT Testimonio FROM Diario WHERE Username = '" + Class1.username + "' AND Fecha = '" + fecha + "';", db);
            commandF.ExecuteNonQuery();
            OleDbDataAdapter adapterF = new OleDbDataAdapter(commandF);
            DataSet datasetF = new DataSet();
            adapterF.Fill(datasetF);
            if (datasetF.Tables[0].Rows.Count == 0)
            {
                if (txtTexto.Text == null)
                {
                    MessageBox.Show("No hay ningun texto escrito");
                }
                else
                {
                    string testimonio = txtTexto.Text;

                    OleDbCommand AgregarTestimonio;
                    AgregarTestimonio = new OleDbCommand("INSERT INTO Diario (Testimonio, Fecha, Username) VALUES ('" + testimonio + "', '" + fecha + "', '" + Class1.username + "');");
                    AgregarTestimonio.Connection = db;
                    AgregarTestimonio.ExecuteNonQuery();
                }
            }
            else
            {
                    string testimonio = txtTexto.Text;

                    OleDbCommand ModificarTestimonio;
                ModificarTestimonio = new OleDbCommand("UPDATE Diario SET Testimonio = '" + txtTexto.Text + "' WHERE Username = '" + Class1.username + "' AND Fecha = '" + fecha + "'");
                    ModificarTestimonio.Connection = db;
                    ModificarTestimonio.ExecuteNonQuery();
            }
            db.Close();
            
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dtfecha_ValueChanged(object sender, EventArgs e)
        {
            db.Open();
            DateTime fecha = dtfecha.Value;
            OleDbCommand commandF;
            commandF = new OleDbCommand("SELECT Testimonio FROM Diario WHERE Username = '" + Class1.username + "' AND Fecha = '" + fecha + "';", db);
            commandF.ExecuteNonQuery();
            OleDbDataAdapter adapterF = new OleDbDataAdapter(commandF);
            DataSet datasetF = new DataSet();
            adapterF.Fill(datasetF);
            if (datasetF.Tables[0].Rows.Count == 0)
            {
            }
            else
            {
                txtTexto.Text = datasetF.Tables[0].Rows[0][0].ToString();
            }
            db.Close();
        }

    }
}

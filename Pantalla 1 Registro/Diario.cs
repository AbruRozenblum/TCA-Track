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
            txtTitulo.Size = new System.Drawing.Size(298, 21);
            txtTitulo.Hide();
            OleDbCommand commandT;
            commandT = new OleDbCommand("SELECT Titulo FROM Diario WHERE Username = '" + Class1.username + "';", db);
            commandT.ExecuteNonQuery();
            OleDbDataAdapter adapterT = new OleDbDataAdapter(commandT);
            DataSet datasetT = new DataSet();
            adapterT.Fill(datasetT);
            for (int i = 0; i < datasetT.Tables[0].Rows.Count; i++)
            {
                cbxTitulo.Items.Add(datasetT.Tables[0].Rows[i][0].ToString();
            }
            dtFecha.Value = DateTime.Now;
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
            /*OleDbCommand commandT;
            commandT = new OleDbCommand("SELECT Testimonio FROM Diario WHERE Username = '" + Class1.username + "' AND Fecha = '" + fecha + "';", db);
            commandT.ExecuteNonQuery();
            OleDbDataAdapter adapterT = new OleDbDataAdapter(commandT);
            DataSet datasetT = new DataSet();
            adapterF.Fill(datasetT);*/
            if (datasetF.Tables[0].Rows.Count == 0)
            {
                if (txtTexto.Text == null)
                {
                    MessageBox.Show("No hay ningun texto escrito");
                }
                else if (txtTitulo == null)
                {
                    MessageBox.Show("Escriba un título");
                }
                else
                {
                    string testimonio = txtTexto.Text;
                    OleDbCommand AgregarTestimonio;
                    AgregarTestimonio = new OleDbCommand("INSERT INTO Diario (Testimonio, Fecha, Username, Titulo) VALUES ('" + testimonio + "', '" + fecha + "', '" + Class1.username + "', '" + txtTitulo.Text + "');");
                    AgregarTestimonio.Connection = db;
                    AgregarTestimonio.ExecuteNonQuery();
                }
            }
            else
            {
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
                txtTitulo.Show();
            }
            else
            {
                txtTexto.Text = datasetF.Tables[0].Rows[0][0].ToString();
            }
            db.Close();
        }

        private void txtTexto_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cbxTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand commandF;
            commandF = new OleDbCommand("SELECT Fecha FROM Diario WHERE Username = '" + Class1.username + "' AND Titulo = '" + cbxTitulo.SelectedItem + "';", db);
            commandF.ExecuteNonQuery();
            OleDbDataAdapter adapterF = new OleDbDataAdapter(commandF);
            DataSet datasetF = new DataSet();
            adapterF.Fill(datasetF);
            dtfecha.Value = Convert.ToDateTime(datasetF.Tables[0].Rows[0][0]);
        }
    }
}

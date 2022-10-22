using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

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
            dtfecha.MaxDate = DateTime.Now;
            dtfecha.Value = DateTime.Now;
            OleDbCommand commandF;
            commandF = new OleDbCommand("SELECT Titulo FROM Diario WHERE Username = '" + Class1.username + "';", db);
            OleDbDataAdapter adapterF = new OleDbDataAdapter(commandF);
            DataSet datasetF = new DataSet();
            adapterF.Fill(datasetF);
            for(int i = 0; i < datasetF.Tables[0].Rows.Count; i++) 
            {
                cmbTitulo.Items.Add(datasetF.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            db.Open();
            DateTime fecha = dtfecha.Value.Date;
            OleDbCommand commandF;
            commandF = new OleDbCommand("SELECT Testimonio FROM Diario WHERE Username = '" + Class1.username + "' AND Fecha = '" + fecha + "';", db);
            OleDbDataAdapter adapterF = new OleDbDataAdapter(commandF);
            DataSet datasetF = new DataSet();
            adapterF.Fill(datasetF);
            if (datasetF.Tables[0].Rows.Count == 0)
            {
                if (txtTexto.Text == "")
                {
                    MessageBox.Show("No hay ningun texto escrito");
                }
                else
                {
                    OleDbCommand commandT;
                    commandT = new OleDbCommand("SELECT Titulo FROM Diario WHERE Username = '" + Class1.username + "';", db);
                    OleDbDataAdapter adapterT = new OleDbDataAdapter(commandT);
                    DataSet datasetT = new DataSet();
                    adapterT.Fill(datasetT);

                    if (datasetT.Tables[0].Rows.Count == 0)
                    {
                        string testimonio = txtTexto.Text;
                        OleDbCommand AgregarTestimonio;
                        AgregarTestimonio = new OleDbCommand("INSERT INTO Diario (Testimonio, Fecha, Username, Titulo) VALUES ('" + testimonio + "', '" + fecha + "', '" + Class1.username + "', '" + txtTitulo.Text + "');");
                        AgregarTestimonio.Connection = db;
                        AgregarTestimonio.ExecuteNonQuery();
                        MessageBox.Show("Se subió el testimonio del dia: " + dtfecha.Value.Date.ToString());
                    }
                }
            }
            else
            {
                OleDbCommand ModificarTestimonio;
                ModificarTestimonio = new OleDbCommand("UPDATE Diario SET Testimonio = '" + txtTexto.Text + "' WHERE Username = '" + Class1.username + "' AND Fecha = '" + fecha + "'");
                ModificarTestimonio.Connection = db;
                ModificarTestimonio.ExecuteNonQuery();
                MessageBox.Show("Se actualizó el testimonio del dia: " + dtfecha.Value.Date.ToString());
            }
            db.Close();

        }

        private void Dtfecha_ValueChanged(object sender, EventArgs e)
        {
            if (db.State ==  ConnectionState.Closed) 
            {
                db.Open();
            }
            OleDbCommand commandF;
            commandF = new OleDbCommand("SELECT Testimonio FROM Diario WHERE Username = '" + Class1.username + "' AND Fecha = '" + dtfecha.Value.Date + "';", db);
            OleDbDataAdapter adapterF = new OleDbDataAdapter(commandF);
            DataSet datasetF = new DataSet();
            adapterF.Fill(datasetF);
            if (datasetF.Tables[0].Rows.Count != 0)
            {
                txtTexto.Text = datasetF.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                txtTexto.Text = "";
            }

            db.Close();
        }

        private void txtTexto_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

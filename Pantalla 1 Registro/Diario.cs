using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pantalla_1_Registro
{
    public partial class Diario : Form
    {
        OleDbConnection db;
        bool existe = false;
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
            OleDbCommand command;
            command = new OleDbCommand("SELECT * FROM Diario WHERE Username = '" + Class1.username + "' AND Fecha = '" + dtfecha.Value.Date + "';", db);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            if (dataset.Tables[0].Rows.Count != 0) 
            {
                existe = true;
                txtTitulo.Hide();
            }
            else
            {
                existe = false;
                txtTitulo.Show();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (existe == true)
            {
                OleDbCommand command;
                command = new OleDbCommand("UPDATE Diario SET Testimonio = '" + txtTexto.Text + "' WHERE Username = '" + Class1.username + "' AND Fecha = ''" + dtfecha.Value.Date + "';", db);
                command.ExecuteNonQuery();
                MessageBox.Show("Se actualizó el testimonio del día " + dtfecha.Value.Date.ToString());
            }
            else
            {
                OleDbCommand command;
                command = new OleDbCommand("INSERT INTO Diario (Testimonio, Fecha, Titulo, Username) ('" + txtTexto.Text + "', '" + dtfecha.Value.Date + "', '" + txtTitulo.Text + "', '" + Class1.username + "');", db);
                command.ExecuteNonQuery();
                MessageBox.Show("Se subió el testimonio del día " + dtfecha.Value.Date.ToString());
            }

        }

        private void Dtfecha_ValueChanged(object sender, EventArgs e)
        {
            OleDbCommand command;
            command = new OleDbCommand("SELECT * FROM Diario WHERE Username = '" + Class1.username + "' AND Fecha = '" + dtfecha.Value.Date.ToString() + "'", db);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            if (dataset.Tables[0].Rows.Count != 0)
            {
                existe = true;
                txtTitulo.Hide();
                txtTexto.Text = dataset.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                existe = false;
                txtTitulo.Show();
                txtTexto.Text = "";
            }
        }

        private void cmbTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand command;
            command = new OleDbCommand("SELECT Fecha FROM Diario WHERE Username = '" + Class1.username + "' AND Titulo = ''" + cmbTitulo.SelectedItem + "';", db);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            dtfecha.Text = dataset.Tables[0].Rows[0][0].ToString();
        }
    }
}

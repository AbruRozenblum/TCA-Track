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
        string fecha;
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
            dtfecha.Value = DateTime.Today;
            db.Open();
            OleDbCommand commandF;
            commandF = new OleDbCommand("SELECT Titulo FROM Diario WHERE Username = '" + Class1.username + "';", db);
            OleDbDataAdapter adapterF = new OleDbDataAdapter(commandF);
            DataSet datasetF = new DataSet();
            adapterF.Fill(datasetF);
            for(int i = 0; i < datasetF.Tables[0].Rows.Count; i++) 
            {
                cmbTitulo.Items.Add(datasetF.Tables[0].Rows[i][0].ToString());
            }
            fecha = dtfecha.Value.Day.ToString() + "/" + dtfecha.Value.Month.ToString() + "/" + dtfecha.Value.Year.ToString();
            OleDbCommand command;
            command = new OleDbCommand("SELECT * FROM Diario WHERE Username = '" + Class1.username + "' AND Fecha = '" + fecha + "';", db);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            if (dataset.Tables[0].Rows.Count != 0) 
            {
                existe = true;
                txtTitulo.Hide();
                OleDbCommand commandt;
                commandt = new OleDbCommand("SELECT Testimonio, Titulo FROM Diario WHERE Username = '" + Class1.username + "' AND Fecha = '" + fecha + "'", db);
                OleDbDataAdapter adaptert = new OleDbDataAdapter(commandt);
                DataSet datasett = new DataSet();
                adaptert.Fill(datasett);
                txtTexto.Text = datasett.Tables[0].Rows[0][0].ToString();
                cmbTitulo.Text = datasett.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                existe = false;
                txtTitulo.Show();
            }
            db.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            db.Open();
            if (existe == true)
            {
                OleDbCommand command;
                command = new OleDbCommand("UPDATE Diario SET Testimonio = '" + txtTexto.Text + "' WHERE Username = '" + Class1.username + "' AND Fecha = '" + fecha + "';", db);
                command.ExecuteNonQuery();
                MessageBox.Show("Se actualizó el testimonio del día " + fecha);
            }
            else
            {
                if (txtTitulo.Text == "")
                {
                    MessageBox.Show("Ingrese el título del testimonio de la fecha");
                }
                else if (txtTexto.Text == "")
                {
                    MessageBox.Show("El texto del día esta vacio");
                }
                else
                {
                    OleDbCommand command;
                    command = new OleDbCommand("INSERT INTO Diario (Testimonio, Fecha, Titulo, Username) VALUES ('" + txtTexto.Text + "', '" + fecha + "', '" + txtTitulo.Text + "', '" + Class1.username + "');", db);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Se subió el testimonio del día " + fecha);
                    
                }
            }
            db.Close();
        }

        private void Dtfecha_ValueChanged(object sender, EventArgs e)
        {
            fecha = dtfecha.Value.Day.ToString() + "/" + dtfecha.Value.Month.ToString() + "/" + dtfecha.Value.Year.ToString();
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            OleDbCommand command;
            command = new OleDbCommand("SELECT Testimonio, Titulo FROM Diario WHERE Username = '" + Class1.username + "' AND Fecha = '" + fecha + "'", db);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            if (dataset.Tables[0].Rows.Count != 0)
            {
                existe = true;
                txtTitulo.Hide();
                txtTexto.Text = dataset.Tables[0].Rows[0][0].ToString();
                cmbTitulo.Text = dataset.Tables[0].Rows[0][1].ToString();
            }
            else
            {
                existe = false;
                txtTitulo.Show();
                txtTexto.Text = "";
                cmbTitulo.Text = "";
            }
            db.Close();
        }

        private void cmbTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            OleDbCommand command;
            command = new OleDbCommand("SELECT Fecha FROM Diario WHERE Username = '" + Class1.username + "' AND Titulo = '" + cmbTitulo.SelectedItem + "';", db);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            dtfecha.Text = dataset.Tables[0].Rows[0][0].ToString();
            db.Close();
        }

        private void TxtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

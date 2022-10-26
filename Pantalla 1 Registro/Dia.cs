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
    public partial class Dia : Form
    {
        OleDbConnection db;
        CheckBox chbAct;
        string Estado;
        public Dia()
        {
            InitializeComponent();
        }

        private void Dia_Load(object sender, EventArgs e)
        {
            
            txtFecha.Text = UserControlDays.static_day + "/" + Calendario.static_month + "/" + Calendario.static_year;

            //conexion base de datos
            db = new OleDbConnection();
            db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
            db.Open();
            OleDbCommand Dia_command = new OleDbCommand("SELECT Evento, Inicio, Checked FROM Calendario WHERE Dia = '" + txtFecha.Text + "'AND Username = '"+ Class1.username +"' ORDER BY Inicio ASC", db);
            OleDbDataAdapter adapter = new OleDbDataAdapter(Dia_command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            // mostrar actividades
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                chbAct = new CheckBox();
                chbAct.Font = new Font("Mongolian Baiti", 12);
                chbAct.Text = dataset.Tables[0].Rows[i]["Evento"].ToString() + " " + dataset.Tables[0].Rows[i]["Inicio"].ToString() + "\n";
                if (dataset.Tables[0].Rows[i]["Checked"].ToString() == "si")
                {
                    chbAct.CheckState = CheckState.Checked;

                }
                else
                {
                    chbAct.CheckState = CheckState.Unchecked;
                }
                flowLayoutPanel1.Controls.Add(chbAct);
                chbAct.CheckedChanged += chbAct_CheckedChanged;
            }
            db.Close();
        }

        private void BtnDiaNE_Click(object sender, EventArgs e)
        {
            //base de datos
            db = new OleDbConnection();
            db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
            db.Open();
            MessageBox.Show("Se guardaron sus cambios");
            this.Hide();
        }

        private void chbAct_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAct.Checked)
            {
                Estado = "si";
                //base de datos
                db = new OleDbConnection();
                db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
                db.Open();
                OleDbCommand EstadoCommand = new OleDbCommand("UPDATE Calendario SET Checked = '" + Estado + "'  WHERE Dia = '" + txtFecha.Text + "' && Username = '" + Class1.username + "' && Evento = '" + chbAct.Text + "'");
                EstadoCommand.Connection = db;
                EstadoCommand.ExecuteNonQuery();
                db.Close();
            }
            else
            {
                Estado = "no";
                //base de datos
                db = new OleDbConnection();
                db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
                db.Open();
                OleDbCommand EstadoCommand = new OleDbCommand("UPDATE Calendario SET Checked = '" + Estado + "'  WHERE Dia = '" + txtFecha.Text + "' AND Username = '" + Class1.username + "' AND Evento = '" + chbAct.Text + "'");
                EstadoCommand.Connection = db;
                EstadoCommand.ExecuteNonQuery();
                db.Close();
            }
        }
    }
 }


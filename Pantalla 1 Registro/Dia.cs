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
            OleDbCommand Dia_command = new OleDbCommand("SELECT Evento, Inicio FROM Calendario WHERE Dia = '" + txtFecha.Text + "'ORDER BY Inicio ASC", db);
            OleDbDataAdapter adapter = new OleDbDataAdapter(Dia_command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            // mostrar actividades

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                TextBox Act = new TextBox();
                Act.Text = dataset.Tables[0].Rows[i]["Evento"].ToString() + " " + dataset.Tables[0].Rows[i]["Inicio"].ToString();
                flowLayoutPanel1.Controls.Add(Act);
            }
        }
        private void BtnDiaNE_Click(object sender, EventArgs e)
        {
            AddEvent formaSiguiente = new AddEvent();
            formaSiguiente.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
 }


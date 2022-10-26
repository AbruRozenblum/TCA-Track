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
    public partial class AddEvent : Form
    {
        OleDbConnection cn;
        string evento;
        string dia;
        string horaI;
        string horaF;
        string descripción;
        string tipo;
        string D;
        string M;
        string A;

        public AddEvent()
        {
            InitializeComponent();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection();
            cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";

            //crear opciones de combobox hora fin y hora inicio
            for (int h = 0; h <= 23; h++)
            {

                cmbHorarioInicio.Items.Add(Convert.ToString(h) + ":00");
                cmbHorarioInicio.Items.Add(Convert.ToString(h) + ":30");
            }
            for (int h = 0; h <= 23; h++)
            {
                cmbHorarioFin.Items.Add(Convert.ToString(h) + ":00");
                cmbHorarioFin.Items.Add(Convert.ToString(h) + ":30");
            }

            // combobox tipo de actividad
            cmbtipo.Items.Add("ejercicio");
            cmbtipo.Items.Add("medicacion");
            cmbtipo.Items.Add("consulta medica");
            cmbtipo.Items.Add("comidas");
            cmbtipo.Items.Add("reuniones");
            cmbtipo.Items.Add("otros");
            if (cmbtipo.SelectedItem != null)
            {
                tipo = cmbtipo.SelectedItem.ToString();
            }
            //combo box date 
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(Convert.ToString(i));
            }
            for (int i = 1; i <= 12; i++)
            {
                cmbmes.Items.Add(Convert.ToString(i));
            }

            for (int i = 2022; i <= 2080; i++)
            {
                cmbaño.Items.Add(Convert.ToString(i));
            }


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            D = comboBox1.SelectedItem.ToString();
            M = cmbmes.SelectedItem.ToString();
            A = cmbaño.SelectedItem.ToString();
            dia = D + "/" + M + "/" + A;
            if (chbTodoelDia.Checked)
            {
                horaI = "00:00";
                horaF = "23:30";
            }
            else
            {
                horaI = cmbHorarioInicio.SelectedItem.ToString();
                horaF = cmbHorarioFin.SelectedItem.ToString();
            }
            evento = txtEvento.Text;
            tipo = cmbtipo.SelectedItem.ToString();
            descripción = rtbDescripcion.Text;
            if (evento != null || dia != null || horaF != null || horaI != null || tipo != null|| descripción!= null)
            {
                cn.Open();
                string query = "INSERT INTO Calendario (Evento, Inicio, Fin, Dia, descripcion,tipo,Username) VALUES ('" + evento + "', '" + horaI + "', '" + horaF + "', '" + dia + "', '" + descripción + "','" + tipo + "','" + Class1.username + "');";
                OleDbCommand MiComando = new OleDbCommand(query);
                MiComando.Connection = cn;
                MiComando.ExecuteNonQuery();
                MessageBox.Show("Su evento fue guardado");
                cn.Close();
                this.Hide();
            }
        }

        private void ChbTodoelDia_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTodoelDia.Checked)
            {
                horaI = "00:00";
                horaF = "23:30";
                cmbHorarioInicio.Enabled = false;
                cmbHorarioFin.Enabled = false;
            }
            else
            {
                cmbHorarioInicio.Enabled = true;
                cmbHorarioFin.Enabled = true;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


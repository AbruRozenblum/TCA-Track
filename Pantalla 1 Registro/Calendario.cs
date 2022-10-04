using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.OleDb;
using System.Net.Mail;

namespace Pantalla_1_Registro
{
    public partial class Calendario : Form
    {
        const string Usuario = "tca.track.mail@gmail.com";
        const string Password = "Proyecto10";


        OleDbConnection db;
        int month, year, day;
        public static bool si;
        public static int static_month, static_year;

        public Calendario()
        {
            InitializeComponent();
        }

        private void BtnIrInicio_Click(object sender, EventArgs e)
        {
            Inicio formaSiguiente = new Inicio();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            day = now.Day;

            displaDays();

            string date = day + "/" + month + "/" + year;

            //conexion base de datos
            db = new OleDbConnection();
            db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
            db.Open();

            //encontrar dia actual en base de datos
            OleDbCommand hoy_command = new OleDbCommand("SELECT Evento, Inicio FROM Calendario WHERE Dia = '" + date + "' ORDER BY Inicio ASC", db);
            OleDbDataAdapter adapter = new OleDbDataAdapter(hoy_command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            //checklist dia actual
            TextBox hoy = new TextBox();
            hoy.Text = date.ToString();
            flowLayoutPanel3.Controls.Add(hoy);
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                CheckBox Act = new CheckBox();
                Act.Text = dataset.Tables[0].Rows[i]["Evento"].ToString() + " " + dataset.Tables[0].Rows[i]["Inicio"].ToString();
                flowLayoutPanel1.Controls.Add(Act);
            }

            /*calendarios checkbox
            OleDbCommand Ejercicio = new OleDbCommand("SELECT Ejercicio FROM Tipo WHERE Username ='" + Class1.username + "' ", db);
            OleDbDataAdapter adapterE = new OleDbDataAdapter(Ejercicio);
            DataSet datasetE = new DataSet();
            adapterE.Fill(datasetE);

            if (datasetE.Tables[0].Rows.Count == 0)
            {
                OleDbCommand crearCal = new OleDbCommand("INSERT INTO Tipo (Ejercicio,Username) VALUES ('"+true+"','" + Class1.username + "' )", db);
                OleDbDataAdapter adapter3 = new OleDbDataAdapter(crearCal);
                DataSet dataset3 = new DataSet();
                adapter3.Fill(dataset3);
            }
            else
            {
                DataRow foundRow = datasetE.Tables["Tipo"].Rows.Find(true);
                if (foundRow != null)
                {
                    chbEjercicio.CheckState = CheckState.Checked;
                    si = true;
                }
                else
                {
                    chbEjercicio.CheckState = CheckState.Unchecked;
                    si = no;
                }
            }

            OleDbCommand Medicación = new OleDbCommand("SELECT Ejercicio FROM Tipo WHERE Username ='" + Class1.username + "' ", db);
            OleDbDataAdapter adapterM = new OleDbDataAdapter(Medicación);
            DataSet datasetM = new DataSet();
            adapterM.Fill(datasetM);

            if (datasetM.Tables[0].Rows.Count == 0)
            {
                OleDbCommand crearCal = new OleDbCommand("INSERT INTO Tipo (Medicacion,Username) VALUES ('" + true + "','" + Class1.username + "' )", db);
                OleDbDataAdapter adapter3 = new OleDbDataAdapter(crearCal);
                DataSet dataset3 = new DataSet();
                adapter3.Fill(dataset3);
            }
            else
            {
                /*DataRow foundRow = datasetM.Tables["Tipo"].Rows.Find(true);
                if (foundRow != null)
                {
                    chbMedicacion.CheckState = CheckState.Checked;
                    si = true;
                }
                else
                {
                    chbMedicacion.CheckState = CheckState.Unchecked;
                }
            }*/
        }
        private void chbEjercicio_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEjercicio.Checked)
            {
                si = true;

            }
            else
            {
                si = false;
            }
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            //limpiar conteiner
            daycontainer.Controls.Clear();

            //resta al mes para anterior mes
            month--;
            if (month < 1)
            {
                year -= 1;
                month = 12;
                displaDays();
            }
            else
            {
                displaDays();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //limpiar conteiner
            daycontainer.Controls.Clear();

            //suma al mes para prox mes
            month++;
            if (month > 12)
            {
                year += 1;
                month = 1;
                displaDays();
            }
            else
            {
                displaDays();
            }
        }

        private void BtnNuevoEvento_Click_1(object sender, EventArgs e)
        {
            AddEvent formaSiguiente = new AddEvent();
            formaSiguiente.Show();
        }

            private void displaDays()
            {

                static_month = month;
                static_year = year;

                string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                lblDATE.Text = monthname + " " + year;

                //primer dia del mes 
                DateTime startofthemonth = new DateTime(year, month, 1);

                // contador de dias en el mes
                int days = DateTime.DaysInMonth(year, month);

                //convertir el comienzo del mes 
                int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

                // user control blank
                for (int i = 1; i < dayoftheweek; i++)
                {
                    UserControlBlank ucblank = new UserControlBlank();
                    daycontainer.Controls.Add(ucblank);
                }

                //user control days
                for (int i = 1; i <= days; i++)
                {
                    UserControlDays ucdays = new UserControlDays();
                    ucdays.days(i);
                    daycontainer.Controls.Add(ucdays);
                }
            }
        public static void EnviarCorreo(StringBuilder Mensaje, DateTime FechaEnvio,string De,string Para, string Asunto, out string error)
        {
            error = "";
            FechaEnvio = DateTime.Now;
            De = Usuario;

            //mail especialista
            OleDbConnection db;
            db = new OleDbConnection();
            db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
            db.Open();
            OleDbCommand commandMailEspecialista = new OleDbCommand("SELECT Mail_especialista FROM Info_Usuario  WHERE Username ='" + Class1.username + "' ", db);
            OleDbDataAdapter adapterME = new OleDbDataAdapter(commandMailEspecialista);
            DataSet datasetME = new DataSet();
            adapterME.Fill(datasetME);
            int contME = datasetME.Tables[0].Rows.Count;

            Para = datasetME.Tables[0].Rows[contME]["Mail_especialista"].ToString();

            //mail asunto
            OleDbCommand commandAsunto = new OleDbCommand("SELECT Nombre_completo FROM Info_Usuario  WHERE Username ='" + Class1.username + "' ", db);
            OleDbDataAdapter adapterAsunto= new OleDbDataAdapter(commandAsunto);
            DataSet datasetAsunto = new DataSet();
            adapterAsunto.Fill(datasetAsunto);
            int contA = datasetAsunto.Tables[0].Rows.Count;
            Asunto = datasetAsunto.Tables[0].Rows[contA]["Nombre_completo"].ToString();

            StringBuilder MensajeBuilder = new StringBuilder();
            MensajeBuilder.Append("actividades con respectivos horarios");
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format("fecha envio: {0:dd/MM/yyyy}" , FechaEnvio));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De);
                mail.To.Add(Para);
                mail.Subject = Asunto;
                mail.Body = Mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(Usuario, Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                error = "Exito";


            }
            catch (Exception ex)
            {
                
                return;
            }
        }
        }
    }

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
        const string Password = "cokgkgcgxzkjfxgi";


        OleDbConnection db;
        int month, year, day;
        public static bool si;
        public static int static_month, static_year;
        string horaactual = DateTime.Now.ToString("HH:mm");
        string horaexacta = "18:15";
        CheckBox chbAct;
        string Estado;
        TextBox hoy;
        public Calendario()
        {
            InitializeComponent();


            //mail especialista
          
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
            hoy = new TextBox();
            hoy.Text = date.ToString();
            flowLayoutPanel3.Controls.Add(hoy);
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                chbAct = new CheckBox();
                chbAct.Text = dataset.Tables[0].Rows[i]["Evento"].ToString() + " " + dataset.Tables[0].Rows[i]["Inicio"].ToString() + "\n";
                flowLayoutPanel1.Controls.Add(chbAct);
                chbAct.CheckedChanged += chbAct_CheckedChanged;
            }
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
                OleDbCommand EstadoCommand = new OleDbCommand("UPDATE Calendario SET Checked = '" + Estado + "'  WHERE Dia = '" + hoy.Text + "' AND Username = '" + Class1.username + "' AND Evento = '" + chbAct.Text + "';", db);
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
                OleDbCommand EstadoCommand = new OleDbCommand("UPDATE Calendario SET Checked = '" + Estado + "'  WHERE Dia = '" + hoy.Text + "' AND Username = '" + Class1.username + "' AND Evento = '" + chbAct.Text + "'");
                EstadoCommand.Connection = db;
                EstadoCommand.ExecuteNonQuery();
                db.Close();
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


        private void Button1_Click(object sender, EventArgs e)
        {
           // EnviarCorreo_Especialista();
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

        private void Calendario_FormClosed(object sender, FormClosedEventArgs e)
        {
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

        public void EnviarCorreo_Especialista()
        {
            if (horaactual == horaexacta)
            {
                StringBuilder Mensaje;
                DateTime FechaEnvio = DateTime.Now;
                string De = Usuario;
                string Para;
                string Asunto;
                string error = "";

                //mail especialista
                OleDbConnection db;
                db = new OleDbConnection();
                db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
                db.Open();
                OleDbCommand commandMailEspecialista = new OleDbCommand("SELECT Mail_especialista FROM Info_usuario WHERE Username ='" + Class1.username + "' ", db);
                OleDbDataAdapter adapterME = new OleDbDataAdapter(commandMailEspecialista);
                DataSet datasetME = new DataSet();
                adapterME.Fill(datasetME);
                int contME = datasetME.Tables[0].Rows.Count;
                Para = datasetME.Tables[0].Rows[contME - 1][0].ToString(); ;

                //mail asunto
                OleDbCommand commandAsunto = new OleDbCommand("SELECT Nombre_completo FROM Info_usuario  WHERE Username ='" + Class1.username + "' ", db);
                OleDbDataAdapter adapterAsunto = new OleDbDataAdapter(commandAsunto);
                DataSet datasetAsunto = new DataSet();
                adapterAsunto.Fill(datasetAsunto);
                int contA = datasetAsunto.Tables[0].Rows.Count;
                Asunto = datasetAsunto.Tables[0].Rows[0][contA - 1].ToString();

                //mail mensaje
                OleDbCommand commandMensaje = new OleDbCommand("SELECT Evento FROM Calendario WHERE tipo = 'comidas' AND Username = '" + Class1.username + "' ", db);
                OleDbDataAdapter adapterMensaje = new OleDbDataAdapter(commandMensaje);
                DataSet datasetMensaje = new DataSet();
                adapterMensaje.Fill(datasetMensaje);

                OleDbCommand commandMensaje2 = new OleDbCommand("SELECT Inicio FROM Calendario WHERE tipo = 'comidas' AND Username = '" + Class1.username + "' ", db);
                OleDbDataAdapter adapterMensaje2 = new OleDbDataAdapter(commandMensaje2);
                DataSet datasetMensaje2 = new DataSet();
                adapterMensaje2.Fill(datasetMensaje2);

                OleDbCommand commandMensaje3 = new OleDbCommand("SELECT Descripcion FROM Calendario WHERE tipo = 'comidas' AND Username = '" + Class1.username + "' ", db);
                OleDbDataAdapter adapterMensaje3 = new OleDbDataAdapter(commandMensaje3);
                DataSet datasetMensaje3 = new DataSet();
                adapterMensaje3.Fill(datasetMensaje3);

                StringBuilder MensajeBuilder = new StringBuilder();


                for (int i = 0; i < datasetMensaje.Tables[0].Rows.Count; i++)
                {
                    MensajeBuilder.Append(datasetMensaje.Tables[0].Rows[i][0].ToString() + "-" + datasetMensaje2.Tables[0].Rows[i][0].ToString() + "\n" + "Descripcion:" + datasetMensaje2.Tables[0].Rows[i][0].ToString() + "\n");
                }
                Mensaje = MensajeBuilder;

                try
                {
                    Mensaje.Append(Environment.NewLine);
                    Mensaje.Append(string.Format("fecha envio: {0:dd/MM/yyyy}", FechaEnvio));
                    Mensaje.Append(Environment.NewLine);

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(De);
                    mail.To.Add(Para);
                    mail.Subject = Asunto;
                    mail.Body = Mensaje.ToString();

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.Port = 25;
                    // smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential(Usuario, Password);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    error = "Exito";
                    MessageBox.Show(error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
     }
 }

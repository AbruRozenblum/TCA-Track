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
    public partial class Inicio : Form
    {
        const string Usuario = "tca.track.mail@gmail.com";
        const string Password = "cokgkgcgxzkjfxgi";


        OleDbConnection db;
        int month, year, day;
        public static bool si;
        public static int static_month, static_year;
        string horaactual;
        string horaexacta = "8:00";
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIrTestimonios_Click(object sender, EventArgs e)
        {
            Testimonios formaSiguiente = new Testimonios();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void btnIrCalendario_Click(object sender, EventArgs e)
        {
            Calendario formaSiguiente = new Calendario();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void btnIrDiario_Click(object sender, EventArgs e)
        {
            Diario formaSiguiente = new Diario();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void btnIrInformacion_Click(object sender, EventArgs e)
        {
            Informacion formaSiguiente = new Informacion();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void btnIrRecetas_Click(object sender, EventArgs e)
        {
            Recetas formaSiguiente = new Recetas();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }


        private void btnIrPerfil_Click(object sender, EventArgs e)
        {
            Perfil formaSiguiente = new Perfil();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            while (true)
            {
                EnviarCorreo_Especialista();
                EnviarCorreo_Notif();
            }
        }
        public void EnviarCorreo_Notif()
        {
            OleDbConnection db;
            db = new OleDbConnection();
            db.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
            db.Open();

            OleDbCommand HoraMail = new OleDbCommand("SELECT Inicio FROM Calendario WHERE Inicio = '" + horaactual + "' AND Username ='" + Class1.username + "'", db);
            OleDbDataAdapter adapterU = new OleDbDataAdapter(HoraMail);
            DataSet datasetHM = new DataSet();
            adapterU.Fill(datasetHM);

            //if (horaactual == datasetHM.Tables[0].Rows[0][0].ToString())
            //{
                StringBuilder Mensaje;
                StringBuilder MensajeBuilder = new StringBuilder();
                DateTime FechaEnvio = DateTime.Now;
                string De = Usuario;
                string Para;
                string Asunto;
                string error = "";

                //Mail usuario
                OleDbCommand commandMailUsuario = new OleDbCommand("SELECT Mail FROM Info_usuario WHERE Username ='" + Class1.username + "' ", db);
                OleDbDataAdapter adapterUS = new OleDbDataAdapter(commandMailUsuario);
                DataSet datasetU = new DataSet();
                adapterUS.Fill(datasetU);
                int contU = datasetU.Tables[0].Rows.Count;
                Para = datasetU.Tables[0].Rows[contU - 1][0].ToString();

                //mail asunto 
                Asunto = "Una de tus actividades programadas se acerca :)";

                //mail mensaje 
                OleDbCommand MensajeN = new OleDbCommand("SELECT Evento FROM Calendario WHERE Username ='" + Class1.username + "' AND Inicio = '" + horaactual + "'", db);
                OleDbDataAdapter adapterN = new OleDbDataAdapter(MensajeN);
                DataSet datasetN = new DataSet();
                adapterN.Fill(datasetN);
                
                if (datasetN.Tables[0].Rows.Count >= 0){ 
                MensajeBuilder.Append("Tu evento: "+datasetN.Tables[0].Rows[0][0].ToString()+" esta programado para este horario, acordate de chequearlo en la app(si es que la cumpliste) asi queda registrado.");
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
        //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnviarCorreo_Notif();
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
                Para = datasetME.Tables[0].Rows[contME - 1][0].ToString();

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
        private void MailDeliverer_Tick(object sender, EventArgs e)
        {
            horaactual = DateTime.Now.ToString("HH:mm");
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}

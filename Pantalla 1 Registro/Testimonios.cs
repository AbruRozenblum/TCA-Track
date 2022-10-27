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
    public partial class Testimonios : Form
    {
        OleDbConnection dataBase;

        public Testimonios()
        {
            InitializeComponent();
        }

        private void Testimonios_Load(object sender, EventArgs e)
        {
            dataBase = new OleDbConnection();
            dataBase.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";

            dataBase.Open();
            OleDbCommand TCA;
            TCA = new OleDbCommand("SELECT Testimonio FROM Testimonios", dataBase);
            OleDbDataAdapter adapter1 = new OleDbDataAdapter(TCA);
            DataSet dataset1 = new DataSet();
            adapter1.Fill(dataset1);
            for (int i = 0; i < dataset1.Tables[0].Rows.Count; i++)
            {
                Button btnTestimonios = new Button();
                {
                    btnTestimonios.Font = new Font("Microsoft Sans Serif", 12);
                    btnTestimonios.Size = new Size(180, 80);
                    btnTestimonios.Text = dataset1.Tables[0].Rows[i][0].ToString();
                    btnTestimonios.ForeColor = Color.White;
                    btnTestimonios.BackgroundImage = Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_19_0859171;
                };
                flowLayoutPanel1.Controls.Add(btnTestimonios);
                btnTestimonios.Click += BtnTestimonios_Click;
            }
        }
        void BtnTestimonios_Click(Object sender, EventArgs e)
        {
            Testimonio formaSiguiente = new Testimonio();
            Class1.testimonio = (sender as Button).Text;
            formaSiguiente.Show(); // muestra la forma2
        }

        private void BtnIrInicio_Click(object sender, EventArgs e)
        {
            Inicio formaSiguiente = new Inicio();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }
    }
}

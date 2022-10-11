using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Pantalla_1_Registro
{
    public partial class Dulces : Form
    {
        OleDbConnection dataBase;
        public Dulces()
        {
            InitializeComponent();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Recetas formaSiguiente = new Recetas();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void Dulces_Load(object sender, EventArgs e)
        {
            dataBase = new OleDbConnection();
            dataBase.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";

            dataBase.Open();
            OleDbCommand nombresRecetas;
            nombresRecetas = new OleDbCommand("SELECT Nombre FROM Recetas WHERE Tipo = 'Dulce'", dataBase);
            OleDbDataAdapter adapter1 = new OleDbDataAdapter(nombresRecetas);
            DataSet dataset1 = new DataSet();
            adapter1.Fill(dataset1);
            for (int i = 0; i < dataset1.Tables[0].Rows.Count; i++)
            {
                Button btnReceta = new Button();
                {
                    btnReceta.Font = new Font("Mongolian Baiti", 14);
                    btnReceta.ForeColor = Color.White;
                    btnReceta.BackgroundImage = Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_19_0859171;
                    btnReceta.Size = new Size(150, 150); 
                    btnReceta.Text = dataset1.Tables[0].Rows[i][0].ToString();
                };
                flowLayoutPanel1.Controls.Add(btnReceta);
                btnReceta.Click += BtnReceta_Click;
            }
        }
        void BtnReceta_Click(Object sender, EventArgs e)
        {
            Receta formaSiguiente = new Receta();
            Class1.nReceta = (sender as Button).Text;
            formaSiguiente.Show(); // muestra la forma2
        }


    }
}


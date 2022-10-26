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
    public partial class Informacion : Form
    {
        OleDbConnection dataBase;
        public Informacion()
        {
            InitializeComponent();
        }

        private void BtnIrInicio_Click(object sender, EventArgs e)
        {
            Inicio formaSiguiente = new Inicio();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            dataBase = new OleDbConnection();
            dataBase.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";

            dataBase.Open();
            OleDbCommand TCA;
            TCA = new OleDbCommand("SELECT TCA FROM Info", dataBase);
            OleDbDataAdapter adapter1 = new OleDbDataAdapter(TCA);
            DataSet dataset1 = new DataSet();
            adapter1.Fill(dataset1);
            for (int i = 0; i < dataset1.Tables[0].Rows.Count; i++)
            {
                Button btnInfo = new Button();
                {
                    btnInfo.Font = new Font("Microsoft Sans Serif", 14);
                    btnInfo.Size = new Size(150, 50);
                    btnInfo.Text = dataset1.Tables[0].Rows[i][0].ToString();
                };
                flowLayoutPanel1.Controls.Add(btnInfo);
                btnInfo.Click += BtnInfo_Click;
            }
        }
        void BtnInfo_Click(Object sender, EventArgs e)
        {
            Info formaSiguiente = new Info();
            Class1.info = (sender as Button).Text;
            formaSiguiente.Show(); // muestra la forma2
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

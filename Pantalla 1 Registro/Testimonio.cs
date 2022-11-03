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
    public partial class Testimonio : Form
    {
        OleDbConnection dataBase;
        public Testimonio()
        {
            InitializeComponent();
        }

        private void Testimonio_Load(object sender, EventArgs e)
        {
            dataBase = new OleDbConnection();
            dataBase.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
            lblTexto.MaximumSize = new System.Drawing.Size(550, 5000);
            OleDbCommand commandI;
            commandI = new OleDbCommand("SELECT Testimonio, Texto FROM Testimonios WHERE Testimonio = '" + Class1.testimonio + "';", dataBase);
            OleDbDataAdapter adapterI = new OleDbDataAdapter(commandI);
            DataSet datasetI = new DataSet();
            adapterI.Fill(datasetI);
            panel1.Size = new Size(600, 550);
            lblTestimonio.Text = datasetI.Tables[0].Rows[0][0].ToString();
            lblTexto.Text = datasetI.Tables[0].Rows[0][1].ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

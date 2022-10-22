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
    public partial class Info : Form
    {
        OleDbConnection dataBase;
        public Info()
        {
            InitializeComponent();
        }

        private void lblingredientes_Click(object sender, EventArgs e)
        {

        }

        private void Info_Load(object sender, EventArgs e)
        {
            dataBase = new OleDbConnection();
            dataBase.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
            OleDbCommand commandI;
            commandI = new OleDbCommand("SELECT Info FROM Info_TCA WHERE TCA = '" + Class1.info + "';", dataBase);
            OleDbDataAdapter adapterI = new OleDbDataAdapter(commandI);
            DataSet datasetI = new DataSet();
            adapterI.Fill(datasetI);
            lblinformacion.Text = datasetI.Tables[0].Rows[0][0].ToString();
            lblNombre.Text = Class1.info;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}

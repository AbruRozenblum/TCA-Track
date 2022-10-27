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
            lblinformacion.MaximumSize = new System.Drawing.Size(550,5000);
            OleDbCommand commandI;
            commandI = new OleDbCommand("SELECT Info FROM Info_TCA WHERE Titulo = '" + Class1.info + "';", dataBase);
            OleDbDataAdapter adapterI = new OleDbDataAdapter(commandI);
            DataSet datasetI = new DataSet();
            adapterI.Fill(datasetI);
            String str = datasetI.Tables[0].Rows[0][0].ToString();
            Console.WriteLine("The initial string: '{0}'", str);
            str = str.Replace(";", Environment.NewLine);
            Console.WriteLine("The final string: '{0}'", str);

            String str1 = datasetI.Tables[0].Rows[0][0].ToString();
            Console.WriteLine("The initial string: '{0}'", str1);
            str1 = str1.Replace(";", Environment.NewLine);
            Console.WriteLine("The final string: '{0}'", str1);
            lblinformacion.Text = str1;
            panel1.Size = new Size (600, 550);
            lblNombre.Text = Class1.info;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}

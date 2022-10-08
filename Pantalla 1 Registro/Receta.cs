using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pantalla_1_Registro
{
    public partial class Receta : Form
    {
        OleDbConnection dataBase;

        public Receta()
        {
            InitializeComponent();
        }

        private void Receta_Load(object sender, EventArgs e)
        {
            dataBase = new OleDbConnection();
            dataBase.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = DB_TCA_TRACK.accdb";
            OleDbCommand commandI;
            commandI = new OleDbCommand("SELECT Ingredientes, Desarrollo FROM Recetas WHERE Nombre = '" + Class1.nReceta + "';", dataBase);
            OleDbDataAdapter adapterI = new OleDbDataAdapter(commandI);
            DataSet datasetI = new DataSet();
            adapterI.Fill(datasetI);
            String str = datasetI.Tables[0].Rows[0][0].ToString();
            Console.WriteLine("The initial string: '{0}'", str);
            str = str.Replace(";", Environment.NewLine);
            Console.WriteLine("The final string: '{0}'", str);

            String str1 = datasetI.Tables[0].Rows[0][1].ToString();
            Console.WriteLine("The initial string: '{0}'", str1);
            str1 = str1.Replace(";", Environment.NewLine);
            Console.WriteLine("The final string: '{0}'", str1);
            lblingredientes.Text = str;
            lblNombre.Text = Class1.nReceta;
            lblprocedimiento.Text = str1;
        }

    }
}

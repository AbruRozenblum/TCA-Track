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
            OleDbCommand commandN;
            commandN = new OleDbCommand("SELECT Nombre FROM Recetas WHERE Nombre = '" + Class1.nReceta + "';", dataBase);
            commandN.ExecuteNonQuery();
            OleDbDataAdapter adapterN = new OleDbDataAdapter(commandN);
            DataSet datasetN = new DataSet();
            adapterN.Fill(datasetN);

            lblNombre.Text = Class1.nReceta;
        }
    }
}

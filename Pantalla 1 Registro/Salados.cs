using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_1_Registro
{
    public partial class Salados : Form
    {
        public Salados()
        {
            InitializeComponent();
        }

        private void BtnIrAtras_Click(object sender, EventArgs e)
        {
            Recetas formaSiguiente = new Recetas();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void BtnReceta2_Click(object sender, EventArgs e)
        {
            MisSaladas formaSiguiente = new MisSaladas();
            formaSiguiente.Show();
        }
    }
}

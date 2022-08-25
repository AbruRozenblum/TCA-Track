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
    public partial class Diario : Form
    {
        public Diario()
        {
            InitializeComponent();
        }

        private void BtnIrInicio_Click(object sender, EventArgs e)
        {
            Inicio formaSiguiente = new Inicio();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void Diario_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

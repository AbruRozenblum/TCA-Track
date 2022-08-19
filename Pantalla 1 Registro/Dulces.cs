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
    public partial class Dulces : Form
    {
        public Dulces()
        {
            InitializeComponent();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnNRe_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnNewB_Click(object sender, EventArgs e)
        {
            Random random = new Random(System.Environment.TickCount);//random location everytime
            Button button = new Button();
            button.Size = new Size(99, 88);
            button.Visible = true;
            this.Controls.Add(button);
            button.Click += BtnNRe_Click;//when the new button is clicked, call this method.
        }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Recetas formaSiguiente = new Recetas();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void BtnReceta1_Click(object sender, EventArgs e)
        {
            Receta_1 formaSiguiente = new Receta_1();
            formaSiguiente.Show();  
        }
    }
}

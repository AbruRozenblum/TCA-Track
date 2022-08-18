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
            TableBlindingSource.Filter = "Firstname LIKE´" & txtBuscador & "%´"
        }

        private void BtnNRe_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnNewB_Click(object sender, EventArgs e)
        {
            Random random = new Random(System.Environment.TickCount);//random location everytime
            Button button = new Button();
            button.Size = new Size(99, 88);
            button.Location = new Point(random.Next(0, this.Size.Width - button.Width), random.Next(0, this.Size.Height - button.Height)); //change this to random or something 
            button.Visible = true;
            this.Controls.Add(button);
            button.Click += BtnNRe_Click;//when the new button is clicked, call this method.
        }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }
    }
}

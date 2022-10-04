using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_1_Registro
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            if (Calendario.si == true)
            {
                pxbEjercicio.Show();
            }
            else
            {
                pxbEjercicio.Hide();
            }
        }
        public void days(int numday)
        {
            lbldays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbldays.Text;
            Dia Diaform = new Dia();
            Diaform.Show();
        }
    }
}

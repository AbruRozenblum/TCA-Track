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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIrTestimonios_Click(object sender, EventArgs e)
        {
            Testimonios formaSiguiente = new Testimonios();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void btnIrCalendario_Click(object sender, EventArgs e)
        {
            Calendario formaSiguiente = new Calendario();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void btnIrDiario_Click(object sender, EventArgs e)
        {
            Diario formaSiguiente = new Diario();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void btnIrInformacion_Click(object sender, EventArgs e)
        {
            Informacion formaSiguiente = new Informacion();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }

        private void btnIrRecetas_Click(object sender, EventArgs e)
        {
            Recetas formaSiguiente = new Recetas();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }


        private void btnIrPerfil_Click(object sender, EventArgs e)
        {
            Perfil formaSiguiente = new Perfil();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra la forma2
        }
    }
}

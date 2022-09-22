namespace Pantalla_1_Registro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMailDelUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtMailEspecialista = new System.Windows.Forms.TextBox();
            this.cmbDiagnostico = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombreEspecialista = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.rbtnOtro = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMailDelUsuario
            // 
            resources.ApplyResources(this.txtMailDelUsuario, "txtMailDelUsuario");
            this.txtMailDelUsuario.Name = "txtMailDelUsuario";
            this.txtMailDelUsuario.TextChanged += new System.EventHandler(this.TxtMailDelUsuario_TextChanged);
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // txtMailEspecialista
            // 
            resources.ApplyResources(this.txtMailEspecialista, "txtMailEspecialista");
            this.txtMailEspecialista.Name = "txtMailEspecialista";
            this.txtMailEspecialista.TextChanged += new System.EventHandler(this.txtMailEspecialista_TextChanged);
            // 
            // cmbDiagnostico
            // 
            resources.ApplyResources(this.cmbDiagnostico, "cmbDiagnostico");
            this.cmbDiagnostico.FormattingEnabled = true;
            this.cmbDiagnostico.Name = "cmbDiagnostico";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // txtContraseña
            // 
            resources.ApplyResources(this.txtContraseña, "txtContraseña");
            this.txtContraseña.Name = "txtContraseña";
            // 
            // txtNombreEspecialista
            // 
            resources.ApplyResources(this.txtNombreEspecialista, "txtNombreEspecialista");
            this.txtNombreEspecialista.Name = "txtNombreEspecialista";
            // 
            // dtFecha
            // 
            resources.ApplyResources(this.dtFecha, "dtFecha");
            this.dtFecha.MaxDate = new System.DateTime(2022, 8, 14, 0, 0, 0, 0);
            this.dtFecha.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__15_05_37;
            resources.ApplyResources(this.btnLogIn, "btnLogIn");
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.White;
            this.btnRegistrarse.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__10_45_44;
            resources.ApplyResources(this.btnRegistrarse, "btnRegistrarse");
            this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // rbtnOtro
            // 
            resources.ApplyResources(this.rbtnOtro, "rbtnOtro");
            this.rbtnOtro.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__09_543;
            this.rbtnOtro.ForeColor = System.Drawing.Color.White;
            this.rbtnOtro.Name = "rbtnOtro";
            this.rbtnOtro.TabStop = true;
            this.rbtnOtro.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            resources.ApplyResources(this.rbtnMasculino, "rbtnMasculino");
            this.rbtnMasculino.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__09_541;
            this.rbtnMasculino.ForeColor = System.Drawing.Color.White;
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            this.rbtnMasculino.CheckedChanged += new System.EventHandler(this.rbtnMasculino_CheckedChanged);
            // 
            // rbtnFemenino
            // 
            resources.ApplyResources(this.rbtnFemenino, "rbtnFemenino");
            this.rbtnFemenino.BackColor = System.Drawing.Color.Transparent;
            this.rbtnFemenino.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__09_542;
            this.rbtnFemenino.ForeColor = System.Drawing.Color.White;
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Vfnsljdnvlo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__09_59_42;
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__10_05_02;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__09_54_58;
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtNombreEspecialista);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.rbtnOtro);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.cmbDiagnostico);
            this.Controls.Add(this.txtMailEspecialista);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtMailDelUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMailDelUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtMailEspecialista;
        private System.Windows.Forms.ComboBox cmbDiagnostico;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnOtro;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombreEspecialista;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}


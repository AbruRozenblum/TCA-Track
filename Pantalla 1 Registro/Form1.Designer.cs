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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ckxVerContraseña = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMailDelUsuario
            // 
            resources.ApplyResources(this.txtMailDelUsuario, "txtMailDelUsuario");
            this.txtMailDelUsuario.Name = "txtMailDelUsuario";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            // 
            // txtMailEspecialista
            // 
            resources.ApplyResources(this.txtMailEspecialista, "txtMailEspecialista");
            this.txtMailEspecialista.Name = "txtMailEspecialista";
            // 
            // cmbDiagnostico
            // 
            this.cmbDiagnostico.BackColor = System.Drawing.Color.White;
            this.cmbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtNombreEspecialista
            // 
            resources.ApplyResources(this.txtNombreEspecialista, "txtNombreEspecialista");
            this.txtNombreEspecialista.Name = "txtNombreEspecialista";
            // 
            // dtFecha
            // 
            this.dtFecha.CalendarTitleBackColor = System.Drawing.Color.Transparent;
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
            this.btnRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarse.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__10_45_44;
            resources.ApplyResources(this.btnRegistrarse, "btnRegistrarse");
            this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Union1;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // ckxVerContraseña
            // 
            resources.ApplyResources(this.ckxVerContraseña, "ckxVerContraseña");
            this.ckxVerContraseña.BackColor = System.Drawing.Color.White;
            this.ckxVerContraseña.Name = "ckxVerContraseña";
            this.ckxVerContraseña.UseVisualStyleBackColor = false;
            this.ckxVerContraseña.CheckedChanged += new System.EventHandler(this.ckxVerContraseña_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRegistrarse;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__09_54_58;
            this.Controls.Add(this.ckxVerContraseña);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox ckxVerContraseña;
    }
}


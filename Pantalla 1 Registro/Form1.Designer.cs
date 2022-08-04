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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMailDelUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMailEspecialista = new System.Windows.Forms.TextBox();
            this.cmbDiagnostico = new System.Windows.Forms.ComboBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnOtro = new System.Windows.Forms.RadioButton();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.cmbDía = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.BIENVENIDOS_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(181, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtMailDelUsuario
            // 
            this.txtMailDelUsuario.Location = new System.Drawing.Point(288, 129);
            this.txtMailDelUsuario.Name = "txtMailDelUsuario";
            this.txtMailDelUsuario.Size = new System.Drawing.Size(267, 20);
            this.txtMailDelUsuario.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(288, 185);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtMailEspecialista
            // 
            this.txtMailEspecialista.Location = new System.Drawing.Point(288, 242);
            this.txtMailEspecialista.Name = "txtMailEspecialista";
            this.txtMailEspecialista.Size = new System.Drawing.Size(267, 20);
            this.txtMailEspecialista.TabIndex = 6;
            // 
            // cmbDiagnostico
            // 
            this.cmbDiagnostico.FormattingEnabled = true;
            this.cmbDiagnostico.Location = new System.Drawing.Point(288, 353);
            this.cmbDiagnostico.Name = "cmbDiagnostico";
            this.cmbDiagnostico.Size = new System.Drawing.Size(267, 21);
            this.cmbDiagnostico.TabIndex = 7;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(288, 402);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(85, 17);
            this.rbtnFemenino.TabIndex = 8;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "radioButton1";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnnMasculino
            // 
            this.rbtnnMasculino.AutoSize = true;
            this.rbtnnMasculino.Location = new System.Drawing.Point(379, 402);
            this.rbtnnMasculino.Name = "rbtnnMasculino";
            this.rbtnnMasculino.Size = new System.Drawing.Size(85, 17);
            this.rbtnnMasculino.TabIndex = 9;
            this.rbtnnMasculino.TabStop = true;
            this.rbtnnMasculino.Text = "radioButton2";
            this.rbtnnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnOtro
            // 
            this.rbtnOtro.AutoSize = true;
            this.rbtnOtro.Location = new System.Drawing.Point(470, 402);
            this.rbtnOtro.Name = "rbtnOtro";
            this.rbtnOtro.Size = new System.Drawing.Size(85, 17);
            this.rbtnOtro.TabIndex = 10;
            this.rbtnOtro.TabStop = true;
            this.rbtnOtro.Text = "radioButton3";
            this.rbtnOtro.UseVisualStyleBackColor = true;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(343, 296);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(81, 21);
            this.cmbMes.TabIndex = 11;
            // 
            // cmbAño
            // 
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(430, 296);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(55, 21);
            this.cmbAño.TabIndex = 12;
            // 
            // cmbDía
            // 
            this.cmbDía.FormattingEnabled = true;
            this.cmbDía.Location = new System.Drawing.Point(288, 296);
            this.cmbDía.Name = "cmbDía";
            this.cmbDía.Size = new System.Drawing.Size(49, 21);
            this.cmbDía.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Color_fondo_registro_;
            this.ClientSize = new System.Drawing.Size(842, 464);
            this.Controls.Add(this.cmbDía);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.rbtnOtro);
            this.Controls.Add(this.rbtnnMasculino);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.cmbDiagnostico);
            this.Controls.Add(this.txtMailEspecialista);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMailDelUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMailDelUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMailEspecialista;
        private System.Windows.Forms.ComboBox cmbDiagnostico;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnnMasculino;
        private System.Windows.Forms.RadioButton rbtnOtro;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.ComboBox cmbDía;
    }
}


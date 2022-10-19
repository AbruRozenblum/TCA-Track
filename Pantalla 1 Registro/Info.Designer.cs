
namespace Pantalla_1_Registro
{
    partial class Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblinformacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblinformacion
            // 
            this.lblinformacion.AutoSize = true;
            this.lblinformacion.BackColor = System.Drawing.Color.Transparent;
            this.lblinformacion.Font = new System.Drawing.Font("Palatino Linotype", 16.125F);
            this.lblinformacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblinformacion.Location = new System.Drawing.Point(224, 232);
            this.lblinformacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblinformacion.Name = "lblinformacion";
            this.lblinformacion.Size = new System.Drawing.Size(292, 58);
            this.lblinformacion.TabIndex = 5;
            this.lblinformacion.Text = "*informacion*";
            this.lblinformacion.Click += new System.EventHandler(this.lblingredientes_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Palatino Linotype", 16.125F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(283, 60);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(184, 58);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "TÍTULO";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_15_a_la_s__09_581;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(12, 31);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 87);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__09_541;
            this.ClientSize = new System.Drawing.Size(744, 865);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblinformacion);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinformacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnVolver;
    }
}
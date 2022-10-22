
namespace Pantalla_1_Registro
{
    partial class Receta
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblingredientes = new System.Windows.Forms.Label();
            this.lblprocedimiento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Palatino Linotype", 16.125F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(148, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 29);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "TÍTULO";
            // 
            // lblingredientes
            // 
            this.lblingredientes.AutoSize = true;
            this.lblingredientes.BackColor = System.Drawing.Color.Transparent;
            this.lblingredientes.Font = new System.Drawing.Font("Palatino Linotype", 16.125F);
            this.lblingredientes.Location = new System.Drawing.Point(114, 90);
            this.lblingredientes.Name = "lblingredientes";
            this.lblingredientes.Size = new System.Drawing.Size(153, 29);
            this.lblingredientes.TabIndex = 1;
            this.lblingredientes.Text = "*ingredientes*";
            // 
            // lblprocedimiento
            // 
            this.lblprocedimiento.AutoSize = true;
            this.lblprocedimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblprocedimiento.Font = new System.Drawing.Font("Palatino Linotype", 16.125F);
            this.lblprocedimiento.Location = new System.Drawing.Point(100, 307);
            this.lblprocedimiento.Name = "lblprocedimiento";
            this.lblprocedimiento.Size = new System.Drawing.Size(175, 29);
            this.lblprocedimiento.TabIndex = 2;
            this.lblprocedimiento.Text = "*procedimiento*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "INGREDIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "PROCEDIMIENTO";
            // 
            // Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__09_544;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblprocedimiento);
            this.Controls.Add(this.lblingredientes);
            this.Controls.Add(this.lblNombre);
            this.Name = "Receta";
            this.Load += new System.EventHandler(this.Receta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblingredientes;
        private System.Windows.Forms.Label lblprocedimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
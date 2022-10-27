
namespace Pantalla_1_Registro
{
    partial class Testimonio
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblTestimonio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Palatino Linotype", 16.125F);
            this.lblTexto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTexto.Location = new System.Drawing.Point(34, 88);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(137, 29);
            this.lblTexto.TabIndex = 8;
            this.lblTexto.Text = "*testimonio*";
            // 
            // lblTestimonio
            // 
            this.lblTestimonio.AutoSize = true;
            this.lblTestimonio.BackColor = System.Drawing.Color.Transparent;
            this.lblTestimonio.Font = new System.Drawing.Font("Palatino Linotype", 16.125F);
            this.lblTestimonio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTestimonio.Location = new System.Drawing.Point(34, 33);
            this.lblTestimonio.Name = "lblTestimonio";
            this.lblTestimonio.Size = new System.Drawing.Size(72, 29);
            this.lblTestimonio.TabIndex = 9;
            this.lblTestimonio.Text = "Titulo";
            this.lblTestimonio.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Testimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__09_541;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.lblTestimonio);
            this.Controls.Add(this.lblTexto);
            this.Name = "Testimonio";
            this.Load += new System.EventHandler(this.Testimonio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTestimonio;
    }
}

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
            this.lblTestimonio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTexto);
            this.panel1.Location = new System.Drawing.Point(39, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 40);
            this.panel1.TabIndex = 10;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Palatino Linotype", 16.125F);
            this.lblTexto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTexto.Location = new System.Drawing.Point(12, 19);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(137, 29);
            this.lblTexto.TabIndex = 5;
            this.lblTexto.Text = "*testimonio*";
            // 
            // Testimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__09_541;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTestimonio);
            this.Name = "Testimonio";
            this.Load += new System.EventHandler(this.Testimonio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTestimonio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTexto;
    }
}
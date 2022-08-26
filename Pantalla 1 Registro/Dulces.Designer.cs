namespace Pantalla_1_Registro
{
    partial class Dulces
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
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnIrAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(1065, 48);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(270, 32);
            this.txtBuscador.TabIndex = 17;
            this.txtBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscador_KeyPress);
            // 
            // btnIrAtras
            // 
            this.btnIrAtras.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_24_083547;
            this.btnIrAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIrAtras.FlatAppearance.BorderSize = 0;
            this.btnIrAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrAtras.Location = new System.Drawing.Point(61, 27);
            this.btnIrAtras.Name = "btnIrAtras";
            this.btnIrAtras.Size = new System.Drawing.Size(76, 53);
            this.btnIrAtras.TabIndex = 16;
            this.btnIrAtras.UseVisualStyleBackColor = true;
            this.btnIrAtras.Click += new System.EventHandler(this.Button16_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_24_083531;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(161, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 53);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_18_134034;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(61, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 604);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_18_134034;
            this.pictureBox2.Location = new System.Drawing.Point(-40, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1068, 605);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Dulces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_19_0859171;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnIrAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Dulces";
            this.Text = "Dulces";
            this.Load += new System.EventHandler(this.Dulces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIrAtras;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
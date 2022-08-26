namespace Pantalla_1_Registro
{
    partial class Salados
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIrAtras = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarReceta = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_24_081352;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(127, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 58);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnIrAtras
            // 
            this.btnIrAtras.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_24_081537;
            this.btnIrAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIrAtras.FlatAppearance.BorderSize = 0;
            this.btnIrAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrAtras.Location = new System.Drawing.Point(49, 23);
            this.btnIrAtras.Name = "btnIrAtras";
            this.btnIrAtras.Size = new System.Drawing.Size(72, 58);
            this.btnIrAtras.TabIndex = 1;
            this.btnIrAtras.UseVisualStyleBackColor = true;
            this.btnIrAtras.Click += new System.EventHandler(this.BtnIrAtras_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(75, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 368);
            this.panel1.TabIndex = 13;
            // 
            // btnAgregarReceta
            // 
            this.btnAgregarReceta.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_24_082841;
            this.btnAgregarReceta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarReceta.FlatAppearance.BorderSize = 0;
            this.btnAgregarReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReceta.Location = new System.Drawing.Point(1011, 544);
            this.btnAgregarReceta.Name = "btnAgregarReceta";
            this.btnAgregarReceta.Size = new System.Drawing.Size(259, 53);
            this.btnAgregarReceta.TabIndex = 14;
            this.btnAgregarReceta.UseVisualStyleBackColor = true;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(1026, 43);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(244, 30);
            this.txtBuscador.TabIndex = 15;
            // 
            // Salados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_24_081521;
            this.ClientSize = new System.Drawing.Size(1300, 621);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnAgregarReceta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIrAtras);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Salados";
            this.Text = "Salados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIrAtras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarReceta;
        private System.Windows.Forms.TextBox txtBuscador;
    }
}

namespace Pantalla_1_Registro
{
    partial class Recetas
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
            this.btnIrInicio = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDulce = new System.Windows.Forms.Button();
            this.btnSalado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIrInicio
            // 
            this.btnIrInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnIrInicio.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__21_01_38;
            this.btnIrInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIrInicio.FlatAppearance.BorderSize = 0;
            this.btnIrInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrInicio.Location = new System.Drawing.Point(88, 59);
            this.btnIrInicio.Name = "btnIrInicio";
            this.btnIrInicio.Size = new System.Drawing.Size(78, 73);
            this.btnIrInicio.TabIndex = 4;
            this.btnIrInicio.UseVisualStyleBackColor = false;
            this.btnIrInicio.Click += new System.EventHandler(this.btnIrInicio_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_15_a_la_s__09_22_35;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(523, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(394, 73);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnDulce
            // 
            this.btnDulce.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_15_a_la_s__09_23_08;
            this.btnDulce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDulce.FlatAppearance.BorderSize = 0;
            this.btnDulce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDulce.Location = new System.Drawing.Point(246, 296);
            this.btnDulce.Name = "btnDulce";
            this.btnDulce.Size = new System.Drawing.Size(382, 381);
            this.btnDulce.TabIndex = 2;
            this.btnDulce.UseVisualStyleBackColor = true;
            this.btnDulce.Click += new System.EventHandler(this.BtnDulce_Click);
            // 
            // btnSalado
            // 
            this.btnSalado.BackColor = System.Drawing.Color.White;
            this.btnSalado.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_15_a_la_s__09_23_40;
            this.btnSalado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalado.FlatAppearance.BorderSize = 0;
            this.btnSalado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalado.Location = new System.Drawing.Point(820, 296);
            this.btnSalado.Name = "btnSalado";
            this.btnSalado.Size = new System.Drawing.Size(382, 381);
            this.btnSalado.TabIndex = 1;
            this.btnSalado.UseVisualStyleBackColor = false;
            this.btnSalado.Click += new System.EventHandler(this.BtnSalado_Click);
            // 
            // Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__21_03_37;
            this.ClientSize = new System.Drawing.Size(1373, 752);
            this.Controls.Add(this.btnIrInicio);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDulce);
            this.Controls.Add(this.btnSalado);
            this.Name = "Recetas";
            this.Text = "Recetas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalado;
        private System.Windows.Forms.Button btnDulce;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIrInicio;
    }
}
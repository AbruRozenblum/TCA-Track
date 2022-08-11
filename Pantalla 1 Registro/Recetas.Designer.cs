
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
            this.btnDulce = new System.Windows.Forms.Button();
            this.btnSalado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDulce
            // 
            this.btnDulce.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_11_115453;
            this.btnDulce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDulce.FlatAppearance.BorderSize = 0;
            this.btnDulce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDulce.Location = new System.Drawing.Point(186, 168);
            this.btnDulce.Name = "btnDulce";
            this.btnDulce.Size = new System.Drawing.Size(217, 207);
            this.btnDulce.TabIndex = 2;
            this.btnDulce.UseVisualStyleBackColor = true;
            // 
            // btnSalado
            // 
            this.btnSalado.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_11_115533;
            this.btnSalado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalado.FlatAppearance.BorderSize = 0;
            this.btnSalado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalado.Location = new System.Drawing.Point(582, 168);
            this.btnSalado.Name = "btnSalado";
            this.btnSalado.Size = new System.Drawing.Size(217, 207);
            this.btnSalado.TabIndex = 1;
            this.btnSalado.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_pantalla_2022_08_11_115554;
            this.pictureBox1.Location = new System.Drawing.Point(-53, -136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1364, 763);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(952, 521);
            this.Controls.Add(this.btnDulce);
            this.Controls.Add(this.btnSalado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Recetas";
            this.Text = "Recetas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalado;
        private System.Windows.Forms.Button btnDulce;
    }
}
namespace Pantalla_1_Registro
{
    partial class Dia
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
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnDiaNE = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFecha.Location = new System.Drawing.Point(12, 32);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(202, 26);
            this.txtFecha.TabIndex = 4;
            // 
            // btnDiaNE
            // 
            this.btnDiaNE.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_10_12_a_la_s__09_541;
            this.btnDiaNE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiaNE.FlatAppearance.BorderSize = 0;
            this.btnDiaNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiaNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDiaNE.Location = new System.Drawing.Point(245, 417);
            this.btnDiaNE.Name = "btnDiaNE";
            this.btnDiaNE.Size = new System.Drawing.Size(115, 36);
            this.btnDiaNE.TabIndex = 2;
            this.btnDiaNE.UseVisualStyleBackColor = true;
            this.btnDiaNE.Click += new System.EventHandler(this.BtnDiaNE_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(202, 321);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Dia
            // 
            this.AcceptButton = this.btnDiaNE;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_10_12_a_la_s__09_45_31;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnDiaNE);
            this.Controls.Add(this.txtFecha);
            this.Name = "Dia";
            this.Text = "Dia";
            this.Load += new System.EventHandler(this.Dia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnDiaNE;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
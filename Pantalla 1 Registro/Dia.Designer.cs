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
            this.txtFecha.Location = new System.Drawing.Point(24, 62);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(6);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(400, 44);
            this.txtFecha.TabIndex = 0;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // btnDiaNE
            // 
            this.btnDiaNE.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_10_12_a_la_s__09_541;
            this.btnDiaNE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiaNE.FlatAppearance.BorderSize = 0;
            this.btnDiaNE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiaNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDiaNE.Location = new System.Drawing.Point(490, 773);
            this.btnDiaNE.Margin = new System.Windows.Forms.Padding(6);
            this.btnDiaNE.Name = "btnDiaNE";
            this.btnDiaNE.Size = new System.Drawing.Size(230, 69);
            this.btnDiaNE.TabIndex = 2;
            this.btnDiaNE.UseVisualStyleBackColor = true;
            this.btnDiaNE.Click += new System.EventHandler(this.BtnDiaNE_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 173);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 617);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Dia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_10_12_a_la_s__09_45_31;
            this.ClientSize = new System.Drawing.Size(744, 865);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnDiaNE);
            this.Controls.Add(this.txtFecha);
            this.Margin = new System.Windows.Forms.Padding(6);
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
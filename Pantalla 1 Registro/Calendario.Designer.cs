
namespace Pantalla_1_Registro
{
    partial class Calendario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDATE = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.chbEjercicio = new System.Windows.Forms.CheckBox();
            this.chbMedicación = new System.Windows.Forms.CheckBox();
            this.chbConsulta = new System.Windows.Forms.CheckBox();
            this.Reuniones = new System.Windows.Forms.CheckBox();
            this.chbComida = new System.Windows.Forms.CheckBox();
            this.Otros = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNuevoEvento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIrInicio
            // 
            this.btnIrInicio.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.flevha_para_atras;
            this.btnIrInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIrInicio.FlatAppearance.BorderSize = 0;
            this.btnIrInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrInicio.Location = new System.Drawing.Point(29, 35);
            this.btnIrInicio.Name = "btnIrInicio";
            this.btnIrInicio.Size = new System.Drawing.Size(53, 40);
            this.btnIrInicio.TabIndex = 1;
            this.btnIrInicio.UseVisualStyleBackColor = true;
            this.btnIrInicio.Click += new System.EventHandler(this.BtnIrInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.C_A_L_E_N_D_A_R_I_O;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(148, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(242, 112);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1097, 607);
            this.daycontainer.TabIndex = 2;
            // 
            // lblDATE
            // 
            this.lblDATE.AutoSize = true;
            this.lblDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDATE.Location = new System.Drawing.Point(855, 38);
            this.lblDATE.Name = "lblDATE";
            this.lblDATE.Size = new System.Drawing.Size(231, 37);
            this.lblDATE.TabIndex = 4;
            this.lblDATE.Text = "MONTH YEAR";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(782, 38);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(67, 34);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click_1);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(709, 38);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(67, 34);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // chbEjercicio
            // 
            this.chbEjercicio.AutoSize = true;
            this.chbEjercicio.Location = new System.Drawing.Point(24, 172);
            this.chbEjercicio.Name = "chbEjercicio";
            this.chbEjercicio.Size = new System.Drawing.Size(66, 17);
            this.chbEjercicio.TabIndex = 7;
            this.chbEjercicio.Text = "Ejercicio";
            this.chbEjercicio.UseVisualStyleBackColor = true;
            // 
            // chbMedicación
            // 
            this.chbMedicación.AutoSize = true;
            this.chbMedicación.Location = new System.Drawing.Point(24, 195);
            this.chbMedicación.Name = "chbMedicación";
            this.chbMedicación.Size = new System.Drawing.Size(81, 17);
            this.chbMedicación.TabIndex = 8;
            this.chbMedicación.Text = "Medicación";
            this.chbMedicación.UseVisualStyleBackColor = true;
            // 
            // chbConsulta
            // 
            this.chbConsulta.AutoSize = true;
            this.chbConsulta.Location = new System.Drawing.Point(24, 218);
            this.chbConsulta.Name = "chbConsulta";
            this.chbConsulta.Size = new System.Drawing.Size(105, 17);
            this.chbConsulta.TabIndex = 9;
            this.chbConsulta.Text = "Consulta Medica";
            this.chbConsulta.UseVisualStyleBackColor = true;
            // 
            // Reuniones
            // 
            this.Reuniones.AutoSize = true;
            this.Reuniones.Location = new System.Drawing.Point(24, 241);
            this.Reuniones.Name = "Reuniones";
            this.Reuniones.Size = new System.Drawing.Size(77, 17);
            this.Reuniones.TabIndex = 10;
            this.Reuniones.Text = "Reuniones";
            this.Reuniones.UseVisualStyleBackColor = true;
            // 
            // chbComida
            // 
            this.chbComida.AutoSize = true;
            this.chbComida.Location = new System.Drawing.Point(24, 264);
            this.chbComida.Name = "chbComida";
            this.chbComida.Size = new System.Drawing.Size(66, 17);
            this.chbComida.TabIndex = 11;
            this.chbComida.Text = "Comidas";
            this.chbComida.UseVisualStyleBackColor = true;
            // 
            // Otros
            // 
            this.Otros.AutoSize = true;
            this.Otros.Location = new System.Drawing.Point(24, 287);
            this.Otros.Name = "Otros";
            this.Otros.Size = new System.Drawing.Size(51, 17);
            this.Otros.TabIndex = 12;
            this.Otros.Text = "Otros";
            this.Otros.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(24, 332);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(153, 32);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 361);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(153, 356);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lunes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Martes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(704, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Miércoles";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(858, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Jueves";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1012, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Viernes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Domingo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1166, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sábado";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNuevoEvento
            // 
            this.btnNuevoEvento.Location = new System.Drawing.Point(24, 100);
            this.btnNuevoEvento.Name = "btnNuevoEvento";
            this.btnNuevoEvento.Size = new System.Drawing.Size(153, 57);
            this.btnNuevoEvento.TabIndex = 22;
            this.btnNuevoEvento.Text = "Nuevo Evento";
            this.btnNuevoEvento.UseVisualStyleBackColor = true;
            this.btnNuevoEvento.Click += new System.EventHandler(this.BtnNuevoEvento_Click_1);
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnNuevoEvento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.Otros);
            this.Controls.Add(this.chbComida);
            this.Controls.Add(this.Reuniones);
            this.Controls.Add(this.chbConsulta);
            this.Controls.Add(this.chbMedicación);
            this.Controls.Add(this.chbEjercicio);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblDATE);
            this.Controls.Add(this.daycontainer);
            this.Controls.Add(this.btnIrInicio);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIrInicio;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Label lblDATE;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.CheckBox chbEjercicio;
        private System.Windows.Forms.CheckBox chbMedicación;
        private System.Windows.Forms.CheckBox chbConsulta;
        private System.Windows.Forms.CheckBox Reuniones;
        private System.Windows.Forms.CheckBox chbComida;
        private System.Windows.Forms.CheckBox Otros;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNuevoEvento;
    }
}
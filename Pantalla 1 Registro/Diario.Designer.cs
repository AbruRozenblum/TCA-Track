﻿
namespace Pantalla_1_Registro
{
    partial class Diario
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
            this.components = new System.ComponentModel.Container();
            this.txtDiario = new System.Windows.Forms.TextBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIrInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cbxTitulo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiario
            // 
            this.txtDiario.BackColor = System.Drawing.Color.BlueViolet;
            this.txtDiario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDiario.Location = new System.Drawing.Point(208, 227);
            this.txtDiario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDiario.Multiline = true;
            this.txtDiario.Name = "txtDiario";
            this.txtDiario.Size = new System.Drawing.Size(1084, 708);
            this.txtDiario.TabIndex = 5;
            // 
            // txtBuscador
            // 
            this.txtBuscador.BackColor = System.Drawing.Color.White;
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtBuscador.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtBuscador.Location = new System.Drawing.Point(2288, 56);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(486, 77);
            this.txtBuscador.TabIndex = 9;
            this.txtBuscador.Text = "Buscador\r\n";
            // 
            // dtfecha
            // 
            this.dtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtfecha.Location = new System.Drawing.Point(1340, 173);
            this.dtfecha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtfecha.MaxDate = new System.DateTime(2022, 9, 13, 0, 0, 0, 0);
            this.dtfecha.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(596, 44);
            this.dtfecha.TabIndex = 2;
            this.dtfecha.Value = new System.DateTime(2022, 9, 13, 0, 0, 0, 0);
            this.dtfecha.ValueChanged += new System.EventHandler(this.Dtfecha_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtTexto);
            this.panel1.Location = new System.Drawing.Point(116, 227);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1820, 1160);
            this.panel1.TabIndex = 10;
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTexto.Location = new System.Drawing.Point(4, 0);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(1780, 1212);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged_1);
            // 
            // btnsave
            // 
            this.btnsave.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_22_a_la_s__13_57_26;
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Location = new System.Drawing.Point(1556, 1417);
            this.btnsave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(380, 123);
            this.btnsave.TabIndex = 1;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_22_a_la_s__13_42_48;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(2058, 213);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(662, 1173);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnIrInicio
            // 
            this.btnIrInicio.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__21_01_38;
            this.btnIrInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIrInicio.FlatAppearance.BorderSize = 0;
            this.btnIrInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrInicio.Location = new System.Drawing.Point(116, 56);
            this.btnIrInicio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnIrInicio.Name = "btnIrInicio";
            this.btnIrInicio.Size = new System.Drawing.Size(132, 117);
            this.btnIrInicio.TabIndex = 1;
            this.btnIrInicio.UseVisualStyleBackColor = true;
            this.btnIrInicio.Click += new System.EventHandler(this.BtnIrInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_22_a_la_s__13_47_38;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(312, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitulo.Location = new System.Drawing.Point(1338, 112);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(196, 44);
            this.txtTitulo.TabIndex = 11;
            // 
            // cbxTitulo
            // 
            this.cbxTitulo.FormattingEnabled = true;
            this.cbxTitulo.Location = new System.Drawing.Point(1340, 112);
            this.cbxTitulo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxTitulo.Name = "cbxTitulo";
            this.cbxTitulo.Size = new System.Drawing.Size(592, 33);
            this.cbxTitulo.TabIndex = 12;
            this.cbxTitulo.SelectedIndexChanged += new System.EventHandler(this.cbxTitulo_SelectedIndexChanged);
            // 
            // Diario
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_09_14_a_la_s__21_03_37;
            this.ClientSize = new System.Drawing.Size(2218, 1507);
            this.Controls.Add(this.cbxTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtDiario);
            this.Controls.Add(this.btnIrInicio);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Diario";
            this.Text = "Diario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Diario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIrInicio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtDiario;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cbxTitulo;
    }
}
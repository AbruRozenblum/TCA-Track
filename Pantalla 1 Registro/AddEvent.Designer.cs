namespace Pantalla_1_Registro
{
    partial class AddEvent
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
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbmes = new System.Windows.Forms.ComboBox();
            this.cmbaño = new System.Windows.Forms.ComboBox();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.cmbHorarioInicio = new System.Windows.Forms.ComboBox();
            this.cmbHorarioFin = new System.Windows.Forms.ComboBox();
            this.chbTodoelDia = new System.Windows.Forms.CheckBox();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEvento
            // 
            this.txtEvento.BackColor = System.Drawing.Color.White;
            this.txtEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEvento.ForeColor = System.Drawing.Color.Black;
            this.txtEvento.Location = new System.Drawing.Point(37, 38);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(321, 26);
            this.txtEvento.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // cmbmes
            // 
            this.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbmes.FormattingEnabled = true;
            this.cmbmes.Location = new System.Drawing.Point(121, 84);
            this.cmbmes.Name = "cmbmes";
            this.cmbmes.Size = new System.Drawing.Size(78, 28);
            this.cmbmes.TabIndex = 2;
            // 
            // cmbaño
            // 
            this.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbaño.FormattingEnabled = true;
            this.cmbaño.Location = new System.Drawing.Point(205, 84);
            this.cmbaño.Name = "cmbaño";
            this.cmbaño.Size = new System.Drawing.Size(78, 28);
            this.cmbaño.TabIndex = 3;
            // 
            // cmbtipo
            // 
            this.cmbtipo.BackColor = System.Drawing.Color.White;
            this.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbtipo.ForeColor = System.Drawing.Color.Black;
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Location = new System.Drawing.Point(38, 129);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(321, 28);
            this.cmbtipo.TabIndex = 4;
            // 
            // cmbHorarioInicio
            // 
            this.cmbHorarioInicio.BackColor = System.Drawing.Color.White;
            this.cmbHorarioInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarioInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbHorarioInicio.FormattingEnabled = true;
            this.cmbHorarioInicio.Location = new System.Drawing.Point(38, 177);
            this.cmbHorarioInicio.Name = "cmbHorarioInicio";
            this.cmbHorarioInicio.Size = new System.Drawing.Size(103, 28);
            this.cmbHorarioInicio.TabIndex = 5;
            // 
            // cmbHorarioFin
            // 
            this.cmbHorarioFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarioFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbHorarioFin.FormattingEnabled = true;
            this.cmbHorarioFin.Location = new System.Drawing.Point(38, 211);
            this.cmbHorarioFin.Name = "cmbHorarioFin";
            this.cmbHorarioFin.Size = new System.Drawing.Size(103, 28);
            this.cmbHorarioFin.TabIndex = 6;
            // 
            // chbTodoelDia
            // 
            this.chbTodoelDia.AutoSize = true;
            this.chbTodoelDia.BackColor = System.Drawing.Color.Transparent;
            this.chbTodoelDia.FlatAppearance.BorderSize = 0;
            this.chbTodoelDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbTodoelDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chbTodoelDia.ForeColor = System.Drawing.Color.White;
            this.chbTodoelDia.Location = new System.Drawing.Point(181, 196);
            this.chbTodoelDia.Name = "chbTodoelDia";
            this.chbTodoelDia.Size = new System.Drawing.Size(102, 24);
            this.chbTodoelDia.TabIndex = 7;
            this.chbTodoelDia.Text = "Todo el día";
            this.chbTodoelDia.UseVisualStyleBackColor = false;
            this.chbTodoelDia.CheckedChanged += new System.EventHandler(this.ChbTodoelDia_CheckedChanged);
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rtbDescripcion.Location = new System.Drawing.Point(37, 254);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(359, 96);
            this.rtbDescripcion.TabIndex = 8;
            this.rtbDescripcion.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_10_12_a_la_s__09_54_58;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(285, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 37);
            this.btnSave.TabIndex = 9;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.125F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Añade título";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.mini_calendario_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.descripcion;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(2, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.mini_reloj;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(2, 177);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 28);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.mini_calendario_2;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(2, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 28);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // AddEvent
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pantalla_1_Registro.Properties.Resources.Captura_de_Pantalla_2022_10_12_a_la_s__09_45_31;
            this.ClientSize = new System.Drawing.Size(411, 396);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.chbTodoelDia);
            this.Controls.Add(this.cmbHorarioFin);
            this.Controls.Add(this.cmbHorarioInicio);
            this.Controls.Add(this.cmbtipo);
            this.Controls.Add(this.cmbaño);
            this.Controls.Add(this.cmbmes);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtEvento);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbmes;
        private System.Windows.Forms.ComboBox cmbaño;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.ComboBox cmbHorarioInicio;
        private System.Windows.Forms.ComboBox cmbHorarioFin;
        private System.Windows.Forms.CheckBox chbTodoelDia;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
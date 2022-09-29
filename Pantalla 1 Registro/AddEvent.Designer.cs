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
            this.SuspendLayout();
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(12, 31);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(321, 20);
            this.txtEvento.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // cmbmes
            // 
            this.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmes.FormattingEnabled = true;
            this.cmbmes.Location = new System.Drawing.Point(96, 73);
            this.cmbmes.Name = "cmbmes";
            this.cmbmes.Size = new System.Drawing.Size(78, 21);
            this.cmbmes.TabIndex = 2;
            // 
            // cmbaño
            // 
            this.cmbaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbaño.FormattingEnabled = true;
            this.cmbaño.Location = new System.Drawing.Point(180, 73);
            this.cmbaño.Name = "cmbaño";
            this.cmbaño.Size = new System.Drawing.Size(78, 21);
            this.cmbaño.TabIndex = 3;
            // 
            // cmbtipo
            // 
            this.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Location = new System.Drawing.Point(12, 131);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(321, 21);
            this.cmbtipo.TabIndex = 4;
            // 
            // cmbHorarioInicio
            // 
            this.cmbHorarioInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarioInicio.FormattingEnabled = true;
            this.cmbHorarioInicio.Location = new System.Drawing.Point(12, 181);
            this.cmbHorarioInicio.Name = "cmbHorarioInicio";
            this.cmbHorarioInicio.Size = new System.Drawing.Size(103, 21);
            this.cmbHorarioInicio.TabIndex = 5;
            // 
            // cmbHorarioFin
            // 
            this.cmbHorarioFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarioFin.FormattingEnabled = true;
            this.cmbHorarioFin.Location = new System.Drawing.Point(12, 211);
            this.cmbHorarioFin.Name = "cmbHorarioFin";
            this.cmbHorarioFin.Size = new System.Drawing.Size(103, 21);
            this.cmbHorarioFin.TabIndex = 6;
            // 
            // chbTodoelDia
            // 
            this.chbTodoelDia.AutoSize = true;
            this.chbTodoelDia.Location = new System.Drawing.Point(144, 199);
            this.chbTodoelDia.Name = "chbTodoelDia";
            this.chbTodoelDia.Size = new System.Drawing.Size(81, 17);
            this.chbTodoelDia.TabIndex = 7;
            this.chbTodoelDia.Text = "Todo el día";
            this.chbTodoelDia.UseVisualStyleBackColor = true;
            this.chbTodoelDia.CheckedChanged += new System.EventHandler(this.ChbTodoelDia_CheckedChanged);
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(12, 254);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(384, 177);
            this.rtbDescripcion.TabIndex = 8;
            this.rtbDescripcion.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(321, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 477);
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
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.Load += new System.EventHandler(this.AddEvent_Load);
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
    }
}
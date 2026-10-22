namespace Aniflex.Client.Vista.VistaEpisodio
{
    partial class FormAgregarEpisodio
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
            cmbSerie = new ComboBox();
            txtNumEpisodio = new TextBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePickerEstreno = new DateTimePicker();
            label6 = new Label();
            btnGuardar = new Button();
            chkEsEspecial = new CheckBox();
            txtCalificacion = new TextBox();
            label5 = new Label();
            txtTitulo = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbSerie
            // 
            cmbSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSerie.FormattingEnabled = true;
            cmbSerie.Location = new Point(171, 108);
            cmbSerie.Name = "cmbSerie";
            cmbSerie.Size = new Size(179, 23);
            cmbSerie.TabIndex = 44;
            // 
            // txtNumEpisodio
            // 
            txtNumEpisodio.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumEpisodio.Location = new Point(170, 138);
            txtNumEpisodio.Margin = new Padding(2);
            txtNumEpisodio.Name = "txtNumEpisodio";
            txtNumEpisodio.Size = new Size(180, 23);
            txtNumEpisodio.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 143);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(98, 17);
            label8.TabIndex = 42;
            label8.Text = "N° Episodio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 110);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 41;
            label7.Text = "Serie:";
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.Format = DateTimePickerFormat.Custom;
            dateTimePickerEstreno.Location = new Point(170, 265);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(181, 23);
            dateTimePickerEstreno.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 270);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 17);
            label6.TabIndex = 39;
            label6.Text = "Fecha Emisión:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(125, 347);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 30);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "Guardar Episodio";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chkEsEspecial
            // 
            chkEsEspecial.AutoSize = true;
            chkEsEspecial.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEsEspecial.Location = new Point(25, 304);
            chkEsEspecial.Margin = new Padding(2);
            chkEsEspecial.Name = "chkEsEspecial";
            chkEsEspecial.Size = new Size(110, 21);
            chkEsEspecial.TabIndex = 37;
            chkEsEspecial.Text = "Es especial";
            chkEsEspecial.UseVisualStyleBackColor = true;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalificacion.Location = new Point(171, 227);
            txtCalificacion.Margin = new Padding(2);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(180, 23);
            txtCalificacion.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 231);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 17);
            label5.TabIndex = 35;
            label5.Text = "Calificación:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(171, 179);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(180, 23);
            txtTitulo.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 184);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 33;
            label3.Text = "Título:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(170, 70);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(181, 23);
            txtId.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 74);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 17);
            label2.TabIndex = 31;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 18);
            label1.TabIndex = 30;
            label1.Text = "AGREGAR EPISODIO";
            // 
            // FormAgregarEpisodio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 399);
            Controls.Add(cmbSerie);
            Controls.Add(txtNumEpisodio);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(btnGuardar);
            Controls.Add(chkEsEspecial);
            Controls.Add(txtCalificacion);
            Controls.Add(label5);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAgregarEpisodio";
            Text = "FormAgregarEpisodio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSerie;
        private TextBox txtNumEpisodio;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePickerEstreno;
        private Label label6;
        private Button btnGuardar;
        private CheckBox chkEsEspecial;
        private TextBox txtCalificacion;
        private Label label5;
        private TextBox txtTitulo;
        private Label label3;
        private TextBox txtId;
        private Label label2;
        private Label label1;
    }
}
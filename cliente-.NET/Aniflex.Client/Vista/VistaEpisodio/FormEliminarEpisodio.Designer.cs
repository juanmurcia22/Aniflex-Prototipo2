namespace Aniflex.Client.Vista.VistaEpisodio
{
    partial class FormEliminarEpisodio
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
            txtNumEliminar = new TextBox();
            label7 = new Label();
            textBoxID = new TextBox();
            label5 = new Label();
            dateTimePickerEstreno = new DateTimePicker();
            label6 = new Label();
            btnEliminar = new Button();
            txtCalificacion = new TextBox();
            txtTitulo = new TextBox();
            chkEsEspecial = new CheckBox();
            label4 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            label1 = new Label();
            cmbSerie = new ComboBox();
            label8 = new Label();
            txtNumEpisodio = new TextBox();
            label9 = new Label();
            label3 = new Label();
            txtSerie = new TextBox();
            SuspendLayout();
            // 
            // txtNumEliminar
            // 
            txtNumEliminar.Location = new Point(162, 106);
            txtNumEliminar.Margin = new Padding(2);
            txtNumEliminar.Name = "txtNumEliminar";
            txtNumEliminar.Size = new Size(163, 23);
            txtNumEliminar.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 110);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 17);
            label7.TabIndex = 57;
            label7.Text = "Nº Episodio";
            // 
            // textBoxID
            // 
            textBoxID.Enabled = false;
            textBoxID.Location = new Point(162, 210);
            textBoxID.Margin = new Padding(2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(163, 23);
            textBoxID.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 214);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 17);
            label5.TabIndex = 55;
            label5.Text = "ID:";
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.Enabled = false;
            dateTimePickerEstreno.Format = DateTimePickerFormat.Short;
            dateTimePickerEstreno.Location = new Point(162, 411);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(163, 23);
            dateTimePickerEstreno.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 416);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 17);
            label6.TabIndex = 53;
            label6.Text = "Fecha Emisión:";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(119, 490);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 31);
            btnEliminar.TabIndex = 52;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Enabled = false;
            txtCalificacion.Location = new Point(162, 366);
            txtCalificacion.Margin = new Padding(2);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(163, 23);
            txtCalificacion.TabIndex = 51;
            // 
            // txtTitulo
            // 
            txtTitulo.Enabled = false;
            txtTitulo.Location = new Point(162, 285);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(163, 23);
            txtTitulo.TabIndex = 49;
            // 
            // chkEsEspecial
            // 
            chkEsEspecial.AutoSize = true;
            chkEsEspecial.Enabled = false;
            chkEsEspecial.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEsEspecial.Location = new Point(19, 455);
            chkEsEspecial.Margin = new Padding(2);
            chkEsEspecial.Name = "chkEsEspecial";
            chkEsEspecial.Size = new Size(110, 21);
            chkEsEspecial.TabIndex = 48;
            chkEsEspecial.Text = "Es especial";
            chkEsEspecial.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 371);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 47;
            label4.Text = "Calificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 289);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 45;
            label2.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(119, 153);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 31);
            btnBuscar.TabIndex = 44;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 18);
            label1.TabIndex = 42;
            label1.Text = "ELIMINAR EPISODIO";
            // 
            // cmbSerie
            // 
            cmbSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSerie.FormattingEnabled = true;
            cmbSerie.Location = new Point(162, 70);
            cmbSerie.Name = "cmbSerie";
            cmbSerie.Size = new Size(163, 23);
            cmbSerie.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 70);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(51, 17);
            label8.TabIndex = 59;
            label8.Text = "Serie:";
            label8.Click += label8_Click;
            // 
            // txtNumEpisodio
            // 
            txtNumEpisodio.Enabled = false;
            txtNumEpisodio.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumEpisodio.Location = new Point(162, 326);
            txtNumEpisodio.Margin = new Padding(2);
            txtNumEpisodio.Name = "txtNumEpisodio";
            txtNumEpisodio.Size = new Size(163, 23);
            txtNumEpisodio.TabIndex = 62;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 328);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 17);
            label9.TabIndex = 61;
            label9.Text = "N° Episodio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 253);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 84;
            label3.Text = "Serie:";
            // 
            // txtSerie
            // 
            txtSerie.Enabled = false;
            txtSerie.Location = new Point(162, 247);
            txtSerie.Margin = new Padding(2);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(163, 23);
            txtSerie.TabIndex = 83;
            // 
            // FormEliminarEpisodio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 538);
            Controls.Add(label3);
            Controls.Add(txtSerie);
            Controls.Add(txtNumEpisodio);
            Controls.Add(label9);
            Controls.Add(cmbSerie);
            Controls.Add(label8);
            Controls.Add(txtNumEliminar);
            Controls.Add(label7);
            Controls.Add(textBoxID);
            Controls.Add(label5);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(txtCalificacion);
            Controls.Add(txtTitulo);
            Controls.Add(chkEsEspecial);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Name = "FormEliminarEpisodio";
            Text = "FormEliminarEpisodio";
            Load += FormEliminarEpisodio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumEliminar;
        private Label label7;
        private TextBox textBoxID;
        private Label label5;
        private DateTimePicker dateTimePickerEstreno;
        private Label label6;
        private Button btnEliminar;
        private TextBox txtCalificacion;
        private TextBox txtTitulo;
        private CheckBox chkEsEspecial;
        private Label label4;
        private Label label2;
        private Button btnBuscar;
        private Label label1;
        private ComboBox cmbSerie;
        private Label label8;
        private TextBox txtNumEpisodio;
        private Label label9;
        private Label label3;
        private TextBox txtSerie;
    }
}
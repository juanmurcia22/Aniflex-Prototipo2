namespace Aniflex.Client.Vista.VistaEpisodio
{
    partial class FormActualizarEpisodio
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
            label3 = new Label();
            txtSerie = new TextBox();
            txtNumEpisodio = new TextBox();
            label9 = new Label();
            cmbSerie = new ComboBox();
            label8 = new Label();
            txtNumEliminar = new TextBox();
            label7 = new Label();
            textBoxID = new TextBox();
            dateTimePickerEstreno = new DateTimePicker();
            label6 = new Label();
            btnActualizar = new Button();
            txtCalificacion = new TextBox();
            txtTitulo = new TextBox();
            chkEsEspecial = new CheckBox();
            label4 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            label1 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 245);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 103;
            label3.Text = "Serie:";
            // 
            // txtSerie
            // 
            txtSerie.Enabled = false;
            txtSerie.Location = new Point(159, 239);
            txtSerie.Margin = new Padding(2);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(163, 23);
            txtSerie.TabIndex = 102;
            // 
            // txtNumEpisodio
            // 
            txtNumEpisodio.Enabled = false;
            txtNumEpisodio.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumEpisodio.Location = new Point(159, 318);
            txtNumEpisodio.Margin = new Padding(2);
            txtNumEpisodio.Name = "txtNumEpisodio";
            txtNumEpisodio.Size = new Size(163, 23);
            txtNumEpisodio.TabIndex = 101;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 320);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 17);
            label9.TabIndex = 100;
            label9.Text = "N° Episodio:";
            // 
            // cmbSerie
            // 
            cmbSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSerie.FormattingEnabled = true;
            cmbSerie.Location = new Point(159, 50);
            cmbSerie.Name = "cmbSerie";
            cmbSerie.Size = new Size(163, 23);
            cmbSerie.TabIndex = 99;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 50);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(51, 17);
            label8.TabIndex = 98;
            label8.Text = "Serie:";
            // 
            // txtNumEliminar
            // 
            txtNumEliminar.Location = new Point(159, 86);
            txtNumEliminar.Margin = new Padding(2);
            txtNumEliminar.Name = "txtNumEliminar";
            txtNumEliminar.Size = new Size(163, 23);
            txtNumEliminar.TabIndex = 97;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 90);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 17);
            label7.TabIndex = 96;
            label7.Text = "Nº Episodio";
            // 
            // textBoxID
            // 
            textBoxID.Enabled = false;
            textBoxID.Location = new Point(159, 202);
            textBoxID.Margin = new Padding(2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(163, 23);
            textBoxID.TabIndex = 95;
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.Enabled = false;
            dateTimePickerEstreno.Format = DateTimePickerFormat.Short;
            dateTimePickerEstreno.Location = new Point(159, 403);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(163, 23);
            dateTimePickerEstreno.TabIndex = 94;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 408);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 17);
            label6.TabIndex = 93;
            label6.Text = "Fecha Emisión:";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(116, 482);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(109, 31);
            btnActualizar.TabIndex = 92;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Enabled = false;
            txtCalificacion.Location = new Point(159, 358);
            txtCalificacion.Margin = new Padding(2);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(163, 23);
            txtCalificacion.TabIndex = 91;
            // 
            // txtTitulo
            // 
            txtTitulo.Enabled = false;
            txtTitulo.Location = new Point(159, 277);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(163, 23);
            txtTitulo.TabIndex = 90;
            // 
            // chkEsEspecial
            // 
            chkEsEspecial.AutoSize = true;
            chkEsEspecial.Enabled = false;
            chkEsEspecial.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEsEspecial.Location = new Point(16, 447);
            chkEsEspecial.Margin = new Padding(2);
            chkEsEspecial.Name = "chkEsEspecial";
            chkEsEspecial.Size = new Size(110, 21);
            chkEsEspecial.TabIndex = 89;
            chkEsEspecial.Text = "Es especial";
            chkEsEspecial.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 363);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 88;
            label4.Text = "Calificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 281);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 87;
            label2.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(116, 145);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 31);
            btnBuscar.TabIndex = 86;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 18);
            label1.TabIndex = 85;
            label1.Text = "ACTUALIZAR EPISODIO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 204);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 17);
            label5.TabIndex = 104;
            label5.Text = "ID:";
            // 
            // FormActualizarEpisodio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 517);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtSerie);
            Controls.Add(txtNumEpisodio);
            Controls.Add(label9);
            Controls.Add(cmbSerie);
            Controls.Add(label8);
            Controls.Add(txtNumEliminar);
            Controls.Add(label7);
            Controls.Add(textBoxID);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(btnActualizar);
            Controls.Add(txtCalificacion);
            Controls.Add(txtTitulo);
            Controls.Add(chkEsEspecial);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Name = "FormActualizarEpisodio";
            Text = "FormActualizarEpisodio";
            Load += FormActualizarEpisodio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtSerie;
        private TextBox txtNumEpisodio;
        private Label label9;
        private ComboBox cmbSerie;
        private Label label8;
        private TextBox txtNumEliminar;
        private Label label7;
        private TextBox textBoxID;
        private DateTimePicker dateTimePickerEstreno;
        private Label label6;
        private Button btnActualizar;
        private TextBox txtCalificacion;
        private TextBox txtTitulo;
        private CheckBox chkEsEspecial;
        private Label label4;
        private Label label2;
        private Button btnBuscar;
        private Label label1;
        private Label label5;
    }
}
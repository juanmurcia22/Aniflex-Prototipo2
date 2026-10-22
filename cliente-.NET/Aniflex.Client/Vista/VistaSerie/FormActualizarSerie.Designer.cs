namespace Aniflex.Client
{
    partial class FormActualizarSerie
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
            txtCalificacion = new TextBox();
            txtTemporadas = new TextBox();
            txtTitulo = new TextBox();
            chkEnEmision = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            txtId = new TextBox();
            label1 = new Label();
            txtIdBuscar = new Label();
            btnActualizar = new Button();
            dateTimePickerEstreno = new DateTimePicker();
            label6 = new Label();
            textBoxID = new TextBox();
            label5 = new Label();
            txtTituloBuscar = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(195, 317);
            txtCalificacion.Margin = new Padding(2);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(161, 23);
            txtCalificacion.TabIndex = 21;
            // 
            // txtTemporadas
            // 
            txtTemporadas.Location = new Point(195, 274);
            txtTemporadas.Margin = new Padding(2);
            txtTemporadas.Name = "txtTemporadas";
            txtTemporadas.Size = new Size(160, 23);
            txtTemporadas.TabIndex = 20;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(195, 235);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(160, 23);
            txtTitulo.TabIndex = 19;
            // 
            // chkEnEmision
            // 
            chkEnEmision.AutoSize = true;
            chkEnEmision.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEnEmision.Location = new Point(49, 401);
            chkEnEmision.Margin = new Padding(2);
            chkEnEmision.Name = "chkEnEmision";
            chkEnEmision.Size = new Size(106, 21);
            chkEnEmision.TabIndex = 18;
            chkEnEmision.Text = "En emisión";
            chkEnEmision.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 321);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 17;
            label4.Text = "Calificación:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 278);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 17);
            label3.TabIndex = 16;
            label3.Text = "Temporadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 239);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 15;
            label2.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(148, 149);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 35);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(195, 67);
            txtId.Margin = new Padding(2);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(160, 22);
            txtId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 18);
            label1.TabIndex = 12;
            label1.Text = "ACTUALIZACIÓN DE DATOS";
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.AutoSize = true;
            txtIdBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBuscar.Location = new Point(49, 73);
            txtIdBuscar.Margin = new Padding(2, 0, 2, 0);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.Size = new Size(94, 17);
            txtIdBuscar.TabIndex = 11;
            txtIdBuscar.Text = "Id a Cargar:";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(148, 440);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(109, 36);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.Format = DateTimePickerFormat.Short;
            dateTimePickerEstreno.Location = new Point(195, 355);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(160, 23);
            dateTimePickerEstreno.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(49, 360);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 17);
            label6.TabIndex = 23;
            label6.Text = "Fecha Estreno:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(195, 198);
            textBoxID.Margin = new Padding(2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(160, 23);
            textBoxID.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 202);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 17);
            label5.TabIndex = 25;
            label5.Text = "ID:";
            label5.Click += label5_Click;
            // 
            // txtTituloBuscar
            // 
            txtTituloBuscar.Location = new Point(195, 108);
            txtTituloBuscar.Margin = new Padding(2);
            txtTituloBuscar.Multiline = true;
            txtTituloBuscar.Name = "txtTituloBuscar";
            txtTituloBuscar.Size = new Size(160, 22);
            txtTituloBuscar.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(49, 114);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 17);
            label7.TabIndex = 27;
            label7.Text = "Titulo";
            label7.Click += label7_Click;
            // 
            // FormActualizarSerie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 489);
            Controls.Add(txtTituloBuscar);
            Controls.Add(label7);
            Controls.Add(textBoxID);
            Controls.Add(label5);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(btnActualizar);
            Controls.Add(txtCalificacion);
            Controls.Add(txtTemporadas);
            Controls.Add(txtTitulo);
            Controls.Add(chkEnEmision);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(txtIdBuscar);
            Margin = new Padding(2);
            Name = "FormActualizarSerie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormActualizar";
            Load += FormActualizar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCalificacion;
        private TextBox txtTemporadas;
        private TextBox txtTitulo;
        private CheckBox chkEnEmision;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnBuscar;
        private TextBox txtId;
        private Label label1;
        private Label txtIdBuscar;
        private Button btnActualizar;
        private DateTimePicker dateTimePickerEstreno;
        private Label label6;
        private TextBox textBoxID;
        private Label label5;
        private TextBox txtTituloBuscar;
        private Label label7;
    }
}
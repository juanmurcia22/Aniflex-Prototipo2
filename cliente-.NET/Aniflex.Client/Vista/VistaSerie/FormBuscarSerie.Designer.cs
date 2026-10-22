namespace Aniflex.Client
{
    partial class FormBuscarSerie
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
            txtIdBuscar = new Label();
            label1 = new Label();
            txtId = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkEnEmision = new CheckBox();
            txtTitulo = new TextBox();
            txtTemporadas = new TextBox();
            txtCalificacion = new TextBox();
            textNombreBuscar = new TextBox();
            label5 = new Label();
            dateTimePickerEstreno = new DateTimePicker();
            label6 = new Label();
            textBoxID = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.AutoSize = true;
            txtIdBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBuscar.Location = new Point(23, 48);
            txtIdBuscar.Margin = new Padding(2, 0, 2, 0);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.Size = new Size(95, 17);
            txtIdBuscar.TabIndex = 0;
            txtIdBuscar.Text = "Id a Buscar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 18);
            label1.TabIndex = 1;
            label1.Text = "BUSQUEDA";
            // 
            // txtId
            // 
            txtId.Location = new Point(166, 42);
            txtId.Margin = new Padding(2);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(163, 22);
            txtId.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(114, 122);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 35);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 210);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 4;
            label2.Text = "Titulo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 249);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 5;
            label3.Text = "Temporadas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 292);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 6;
            label4.Text = "Calificación:";
            // 
            // chkEnEmision
            // 
            chkEnEmision.AutoSize = true;
            chkEnEmision.Enabled = false;
            chkEnEmision.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEnEmision.Location = new Point(20, 369);
            chkEnEmision.Margin = new Padding(2);
            chkEnEmision.Name = "chkEnEmision";
            chkEnEmision.Size = new Size(106, 21);
            chkEnEmision.TabIndex = 7;
            chkEnEmision.Text = "En emisión";
            chkEnEmision.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(89, 206);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(236, 23);
            txtTitulo.TabIndex = 8;
            // 
            // txtTemporadas
            // 
            txtTemporadas.Location = new Point(157, 245);
            txtTemporadas.Margin = new Padding(2);
            txtTemporadas.Name = "txtTemporadas";
            txtTemporadas.ReadOnly = true;
            txtTemporadas.Size = new Size(169, 23);
            txtTemporadas.TabIndex = 9;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(165, 288);
            txtCalificacion.Margin = new Padding(2);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.ReadOnly = true;
            txtCalificacion.Size = new Size(161, 23);
            txtCalificacion.TabIndex = 10;
            // 
            // textNombreBuscar
            // 
            textNombreBuscar.Location = new Point(166, 83);
            textNombreBuscar.Margin = new Padding(2);
            textNombreBuscar.Multiline = true;
            textNombreBuscar.Name = "textNombreBuscar";
            textNombreBuscar.Size = new Size(164, 22);
            textNombreBuscar.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 89);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 17);
            label5.TabIndex = 11;
            label5.Text = "Nombre a Buscar:";
            label5.Click += label5_Click;
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.Enabled = false;
            dateTimePickerEstreno.Format = DateTimePickerFormat.Short;
            dateTimePickerEstreno.Location = new Point(166, 327);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(160, 23);
            dateTimePickerEstreno.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 332);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 17);
            label6.TabIndex = 25;
            label6.Text = "Fecha Estreno:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(89, 170);
            textBoxID.Margin = new Padding(2);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(236, 23);
            textBoxID.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 174);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(28, 17);
            label7.TabIndex = 27;
            label7.Text = "ID:";
            // 
            // FormBuscarSerie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 424);
            Controls.Add(textBoxID);
            Controls.Add(label7);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(textNombreBuscar);
            Controls.Add(label5);
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
            Name = "FormBuscarSerie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBuscar";
            Load += FormBuscar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtIdBuscar;
        private Label label1;
        private TextBox txtId;
        private Button btnBuscar;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkEnEmision;
        private TextBox txtTitulo;
        private TextBox txtTemporadas;
        private TextBox txtCalificacion;
        private TextBox textNombreBuscar;
        private Label label5;
        private DateTimePicker dateTimePickerEstreno;
        private Label label6;
        private TextBox textBoxID;
        private Label label7;
    }
}
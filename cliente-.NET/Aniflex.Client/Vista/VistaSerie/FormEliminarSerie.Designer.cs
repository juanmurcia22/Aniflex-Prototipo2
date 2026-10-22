namespace Aniflex.Client
{
    partial class FormEliminarSerie
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
            btnEliminar = new Button();
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
            dateTimePickerEstreno = new DateTimePicker();
            label6 = new Label();
            textBoxID = new TextBox();
            label5 = new Label();
            txtTituloEliminar = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(139, 467);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 31);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Enabled = false;
            txtCalificacion.Location = new Point(182, 343);
            txtCalificacion.Margin = new Padding(2);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(163, 23);
            txtCalificacion.TabIndex = 33;
            // 
            // txtTemporadas
            // 
            txtTemporadas.Enabled = false;
            txtTemporadas.Location = new Point(182, 300);
            txtTemporadas.Margin = new Padding(2);
            txtTemporadas.Name = "txtTemporadas";
            txtTemporadas.Size = new Size(163, 23);
            txtTemporadas.TabIndex = 32;
            // 
            // txtTitulo
            // 
            txtTitulo.Enabled = false;
            txtTitulo.Location = new Point(182, 262);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(163, 23);
            txtTitulo.TabIndex = 31;
            // 
            // chkEnEmision
            // 
            chkEnEmision.AutoSize = true;
            chkEnEmision.Enabled = false;
            chkEnEmision.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEnEmision.Location = new Point(39, 432);
            chkEnEmision.Margin = new Padding(2);
            chkEnEmision.Name = "chkEnEmision";
            chkEnEmision.Size = new Size(106, 21);
            chkEnEmision.TabIndex = 30;
            chkEnEmision.Text = "En emisión";
            chkEnEmision.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 348);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 29;
            label4.Text = "Calificacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 304);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 28;
            label3.Text = "Temporadas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 266);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 27;
            label2.Text = "Titulo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(139, 163);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 31);
            btnBuscar.TabIndex = 26;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(182, 79);
            txtId.Margin = new Padding(2);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(163, 22);
            txtId.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 18);
            label1.TabIndex = 24;
            label1.Text = "ELIMINAR SERIE";
            label1.Click += label1_Click;
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.AutoSize = true;
            txtIdBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBuscar.Location = new Point(39, 85);
            txtIdBuscar.Margin = new Padding(2, 0, 2, 0);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.Size = new Size(103, 17);
            txtIdBuscar.TabIndex = 23;
            txtIdBuscar.Text = "Id a Eliminar:";
            txtIdBuscar.Click += txtIdBuscar_Click;
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.Enabled = false;
            dateTimePickerEstreno.Format = DateTimePickerFormat.Short;
            dateTimePickerEstreno.Location = new Point(182, 388);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(163, 23);
            dateTimePickerEstreno.TabIndex = 36;
            dateTimePickerEstreno.ValueChanged += dateTimePickerEstreno_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 393);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 17);
            label6.TabIndex = 35;
            label6.Text = "Fecha Estreno:";
            label6.Click += label6_Click;
            // 
            // textBoxID
            // 
            textBoxID.Enabled = false;
            textBoxID.Location = new Point(182, 220);
            textBoxID.Margin = new Padding(2);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(163, 23);
            textBoxID.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 224);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(28, 17);
            label5.TabIndex = 37;
            label5.Text = "ID:";
            // 
            // txtTituloEliminar
            // 
            txtTituloEliminar.Location = new Point(182, 116);
            txtTituloEliminar.Margin = new Padding(2);
            txtTituloEliminar.Name = "txtTituloEliminar";
            txtTituloEliminar.Size = new Size(163, 23);
            txtTituloEliminar.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 120);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 39;
            label7.Text = "Titulo:";
            // 
            // FormEliminarSerie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 525);
            Controls.Add(txtTituloEliminar);
            Controls.Add(label7);
            Controls.Add(textBoxID);
            Controls.Add(label5);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
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
            Name = "FormEliminarSerie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEliminar";
            Load += FormEliminar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
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
        private DateTimePicker dateTimePickerEstreno;
        private Label label6;
        private TextBox textBoxID;
        private Label label5;
        private TextBox txtTituloEliminar;
        private Label label7;
    }
}
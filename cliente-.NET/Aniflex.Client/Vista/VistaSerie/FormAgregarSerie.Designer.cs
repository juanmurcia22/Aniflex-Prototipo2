namespace Aniflex.Client
{
    partial class FormAgregarSerie
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
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            txtTitulo = new TextBox();
            label4 = new Label();
            txtTemporadas = new TextBox();
            label5 = new Label();
            txtCalificacion = new TextBox();
            chkEnEmision = new CheckBox();
            btnGuardar = new Button();
            label6 = new Label();
            dateTimePickerEstreno = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 18);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR SERIE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 55);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 17);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(198, 51);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(181, 23);
            txtId.TabIndex = 2;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 3;
            label3.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitulo.Location = new Point(198, 89);
            txtTitulo.Margin = new Padding(2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(180, 23);
            txtTitulo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(52, 131);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 17);
            label4.TabIndex = 5;
            label4.Text = "Temporadas:";
            // 
            // txtTemporadas
            // 
            txtTemporadas.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTemporadas.Location = new Point(198, 127);
            txtTemporadas.Margin = new Padding(2);
            txtTemporadas.Name = "txtTemporadas";
            txtTemporadas.Size = new Size(181, 23);
            txtTemporadas.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(52, 169);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 17);
            label5.TabIndex = 7;
            label5.Text = "Calificación:";
            // 
            // txtCalificacion
            // 
            txtCalificacion.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalificacion.Location = new Point(198, 165);
            txtCalificacion.Margin = new Padding(2);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(180, 23);
            txtCalificacion.TabIndex = 8;
            // 
            // chkEnEmision
            // 
            chkEnEmision.AutoSize = true;
            chkEnEmision.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEnEmision.Location = new Point(52, 242);
            chkEnEmision.Margin = new Padding(2);
            chkEnEmision.Name = "chkEnEmision";
            chkEnEmision.Size = new Size(106, 21);
            chkEnEmision.TabIndex = 9;
            chkEnEmision.Text = "En emisión";
            chkEnEmision.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(153, 282);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 30);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar Serie";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(51, 208);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 17);
            label6.TabIndex = 11;
            label6.Text = "Fecha Estreno:";
            label6.Click += label6_Click;
            // 
            // dateTimePickerEstreno
            // 
            dateTimePickerEstreno.Format = DateTimePickerFormat.Custom;
            dateTimePickerEstreno.Location = new Point(197, 203);
            dateTimePickerEstreno.Name = "dateTimePickerEstreno";
            dateTimePickerEstreno.Size = new Size(181, 23);
            dateTimePickerEstreno.TabIndex = 12;
            // 
            // FormAgregarSerie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 325);
            Controls.Add(dateTimePickerEstreno);
            Controls.Add(label6);
            Controls.Add(btnGuardar);
            Controls.Add(chkEnEmision);
            Controls.Add(txtCalificacion);
            Controls.Add(label5);
            Controls.Add(txtTemporadas);
            Controls.Add(label4);
            Controls.Add(txtTitulo);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FormAgregarSerie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private TextBox txtTitulo;
        private Label label4;
        private TextBox txtTemporadas;
        private Label label5;
        private TextBox txtCalificacion;
        private CheckBox chkEnEmision;
        private Button btnGuardar;
        private Label label6;
        private DateTimePicker dateTimePickerEstreno;
    }
}
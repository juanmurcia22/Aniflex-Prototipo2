namespace Aniflex.Client
{
    partial class FormListarSerie
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
            dgvSeries = new DataGridView();
            btnCargar = new Button();
            label1 = new Label();
            txtTituloContiene = new TextBox();
            textCalificacionMin = new TextBox();
            label4 = new Label();
            label2 = new Label();
            buttonFiltrar = new Button();
            buttonLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSeries).BeginInit();
            SuspendLayout();
            // 
            // dgvSeries
            // 
            dgvSeries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeries.Location = new Point(14, 150);
            dgvSeries.Margin = new Padding(2);
            dgvSeries.Name = "dgvSeries";
            dgvSeries.RowHeadersWidth = 62;
            dgvSeries.Size = new Size(528, 205);
            dgvSeries.TabIndex = 0;
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(404, 41);
            btnCargar.Margin = new Padding(2);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(135, 27);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar Series";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += FormListar_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 18);
            label1.TabIndex = 2;
            label1.Text = "SERIES DISPONIBLES";
            // 
            // txtTituloContiene
            // 
            txtTituloContiene.Location = new Point(14, 76);
            txtTituloContiene.Margin = new Padding(2);
            txtTituloContiene.Name = "txtTituloContiene";
            txtTituloContiene.Size = new Size(163, 23);
            txtTituloContiene.TabIndex = 32;
            // 
            // textCalificacionMin
            // 
            textCalificacionMin.Location = new Point(212, 76);
            textCalificacionMin.Margin = new Padding(2);
            textCalificacionMin.Name = "textCalificacionMin";
            textCalificacionMin.Size = new Size(163, 23);
            textCalificacionMin.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 57);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 17);
            label4.TabIndex = 34;
            label4.Text = "Título contiene";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(212, 57);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 17);
            label2.TabIndex = 35;
            label2.Text = "Calificación min.";
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFiltrar.Location = new Point(404, 72);
            buttonFiltrar.Margin = new Padding(2);
            buttonFiltrar.Name = "buttonFiltrar";
            buttonFiltrar.Size = new Size(135, 27);
            buttonFiltrar.TabIndex = 36;
            buttonFiltrar.Text = "Filtrar";
            buttonFiltrar.UseVisualStyleBackColor = true;
            buttonFiltrar.Click += buttonFiltrar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLimpiar.Location = new Point(404, 103);
            buttonLimpiar.Margin = new Padding(2);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(135, 27);
            buttonLimpiar.TabIndex = 37;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click_1;
            // 
            // FormListarSerie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 375);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonFiltrar);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(textCalificacionMin);
            Controls.Add(txtTituloContiene);
            Controls.Add(label1);
            Controls.Add(btnCargar);
            Controls.Add(dgvSeries);
            Margin = new Padding(2);
            Name = "FormListarSerie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListar";
            Load += FormListar_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvSeries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSeries;
        private Button btnCargar;
        private Label label1;
        private TextBox txtTituloContiene;
        private TextBox textCalificacionMin;
        private Label label4;
        private Label label2;
        private Button buttonFiltrar;
        private Button buttonLimpiar;
    }
}
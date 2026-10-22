namespace Aniflex.Client.Vista.VistaEpisodio
{
    partial class FormListarEpisodio
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
            buttonLimpiar = new Button();
            label1 = new Label();
            btnCargar = new Button();
            dgvEpisodios = new DataGridView();
            txtTituloContiene = new TextBox();
            label4 = new Label();
            cmbSerie = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEpisodios).BeginInit();
            SuspendLayout();
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLimpiar.Location = new Point(401, 99);
            buttonLimpiar.Margin = new Padding(2);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(135, 27);
            buttonLimpiar.TabIndex = 46;
            buttonLimpiar.Text = "Limpiar Filtros";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 18);
            label1.TabIndex = 40;
            label1.Text = "EPISODIOS REGISTRADOS";
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(401, 62);
            btnCargar.Margin = new Padding(2);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(135, 27);
            btnCargar.TabIndex = 39;
            btnCargar.Text = "Cargar Episodios";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // dgvEpisodios
            // 
            dgvEpisodios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpisodios.Location = new Point(11, 156);
            dgvEpisodios.Margin = new Padding(2);
            dgvEpisodios.Name = "dgvEpisodios";
            dgvEpisodios.RowHeadersWidth = 62;
            dgvEpisodios.Size = new Size(528, 205);
            dgvEpisodios.TabIndex = 38;
            // 
            // txtTituloContiene
            // 
            txtTituloContiene.Location = new Point(11, 82);
            txtTituloContiene.Margin = new Padding(2);
            txtTituloContiene.Name = "txtTituloContiene";
            txtTituloContiene.Size = new Size(163, 23);
            txtTituloContiene.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 63);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 17);
            label4.TabIndex = 43;
            label4.Text = "Título contiene";
            // 
            // cmbSerie
            // 
            cmbSerie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSerie.FormattingEnabled = true;
            cmbSerie.Location = new Point(204, 82);
            cmbSerie.Name = "cmbSerie";
            cmbSerie.Size = new Size(163, 23);
            cmbSerie.TabIndex = 62;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(204, 62);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(51, 17);
            label8.TabIndex = 61;
            label8.Text = "Serie:";
            // 
            // FormListarEpisodio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 376);
            Controls.Add(cmbSerie);
            Controls.Add(label8);
            Controls.Add(buttonLimpiar);
            Controls.Add(label4);
            Controls.Add(txtTituloContiene);
            Controls.Add(label1);
            Controls.Add(btnCargar);
            Controls.Add(dgvEpisodios);
            Name = "FormListarEpisodio";
            Text = "FormListarEpisodio";
            Load += FormListarEpisodio_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvEpisodios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLimpiar;
        private Label label1;
        private Button btnCargar;
        private DataGridView dgvEpisodios;
        private TextBox txtTituloContiene;
        private Label label4;
        private ComboBox cmbSerie;
        private Label label8;
    }
}
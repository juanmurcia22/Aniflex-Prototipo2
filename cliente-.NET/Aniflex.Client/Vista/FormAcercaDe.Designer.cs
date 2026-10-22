namespace Aniflex.Client
{
    partial class FormAcercaDe
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
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(336, 74);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 0;
            label1.Text = "Hecho por:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(100, 285);
            label2.Name = "label2";
            label2.Size = new Size(619, 37);
            label2.TabIndex = 1;
            label2.Text = "Jamed Alejandro Sánchez Bermudez - 2220242030";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(143, 231);
            label3.Name = "label3";
            label3.Size = new Size(532, 37);
            label3.TabIndex = 2;
            label3.Text = "Juan Camilo Murcia Cardozo - 2220232024";
            label3.Click += this.label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(152, 177);
            label4.Name = "label4";
            label4.Size = new Size(515, 37);
            label4.TabIndex = 3;
            label4.Text = "Daniel Alejandro Ruiz Vidal - 2220222028";
            label4.Click += this.label4_Click;
            // 
            // FormAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAcercaDe";
            Text = "FormAcercaDe";
            Load += FormAcercaDe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
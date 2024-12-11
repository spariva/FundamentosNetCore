namespace FundamentosNetCore
{
    partial class Form03DiaNacimiento
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
            btnCalcular = new Button();
            lblDiaSemana = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnyo = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(195, 352);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "button1";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(446, 76);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(38, 15);
            lblDiaSemana.TabIndex = 1;
            lblDiaSemana.Text = "label1";
            lblDiaSemana.Click += label1_Click;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(195, 76);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 2;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(195, 164);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 3;
            txtMes.TextChanged += textBox2_TextChanged;
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(195, 253);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(100, 23);
            txtAnyo.TabIndex = 4;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAnyo);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblDiaSemana);
            Controls.Add(btnCalcular);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblDiaSemana;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnyo;
    }
}
namespace FundamentosNetCore
{
    partial class Form12ColeccionNumeros
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
            btnGenerar = new Button();
            btnMostrar = new Button();
            txtSuma = new TextBox();
            txtResta = new TextBox();
            txtImpares = new TextBox();
            lstNum = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(585, 12);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(585, 93);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(585, 178);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 2;
            txtSuma.TextChanged += txtSuma_TextChanged;
            // 
            // txtResta
            // 
            txtResta.Location = new Point(585, 245);
            txtResta.Name = "txtResta";
            txtResta.Size = new Size(100, 23);
            txtResta.TabIndex = 3;
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(585, 327);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 4;
            // 
            // lstNum
            // 
            lstNum.FormattingEnabled = true;
            lstNum.Location = new Point(100, 82);
            lstNum.Name = "lstNum";
            lstNum.Size = new Size(308, 304);
            lstNum.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(585, 160);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 6;
            label1.Text = "Suma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(585, 227);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "Resta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(585, 309);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 8;
            label3.Text = "Impares";
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstNum);
            Controls.Add(txtImpares);
            Controls.Add(txtResta);
            Controls.Add(txtSuma);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private Button btnMostrar;
        private TextBox txtSuma;
        private TextBox txtResta;
        private TextBox txtImpares;
        private ListBox lstNum;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
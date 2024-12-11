namespace FundamentosNetCore
{
    partial class Form05Char
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
            this.txtPuntuacion = new TextBox();
            this.txtSimbolos = new TextBox();
            txtLetras = new TextBox();
            txtNumeros = new TextBox();
            btnRun = new Button();
            SuspendLayout();
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new Point(500, 300);
            this.txtPuntuacion.Multiline = true;
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new Size(209, 95);
            this.txtPuntuacion.TabIndex = 1;
            // 
            // txtSimbolos
            // 
            this.txtSimbolos.Location = new Point(70, 300);
            this.txtSimbolos.Multiline = true;
            this.txtSimbolos.Name = "txtSimbolos";
            this.txtSimbolos.Size = new Size(219, 95);
            this.txtSimbolos.TabIndex = 2;
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(500, 66);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(209, 76);
            txtLetras.TabIndex = 3;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(70, 66);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(209, 76);
            txtNumeros.TabIndex = 4;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(340, 219);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 23);
            btnRun.TabIndex = 5;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRun);
            Controls.Add(txtNumeros);
            Controls.Add(txtLetras);
            Controls.Add(this.txtSimbolos);
            Controls.Add(this.txtPuntuacion);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private Button btnRun;
        private TextBox txtPuntuacion;
        private TextBox txtSimbolos;
    }
}
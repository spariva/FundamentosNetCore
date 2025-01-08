namespace FundamentosNetCore
{
    partial class Form22Mascotas
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
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(34, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(34, 151);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(48, 234);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "new";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(48, 305);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "leer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(48, 363);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(266, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(482, 379);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form22Mascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Name = "Form22Mascotas";
            Text = "Form22Mascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtRaza;
        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
    }
}
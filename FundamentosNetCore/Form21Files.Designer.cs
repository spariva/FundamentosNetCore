namespace FundamentosNetCore
{
    partial class Form21Files
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
            lblFile = new Label();
            lstFile = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnNombre = new Button();
            btnRead = new Button();
            btnWrite = new Button();
            lstNombres = new TextBox();
            label3 = new Label();
            lstBoxNombres = new ListBox();
            SuspendLayout();
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(45, 9);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(84, 15);
            lblFile.TabIndex = 0;
            lblFile.Text = "Contenido File";
            // 
            // lstFile
            // 
            lstFile.Location = new Point(45, 36);
            lstFile.Multiline = true;
            lstFile.Name = "lstFile";
            lstFile.Size = new Size(377, 385);
            lstFile.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 72);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(428, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(134, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(428, 162);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(134, 37);
            btnNombre.TabIndex = 4;
            btnNombre.Text = "Nuevo Nombre";
            btnNombre.UseVisualStyleBackColor = true;
            btnNombre.Click += btnNombre_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(428, 218);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(134, 37);
            btnRead.TabIndex = 5;
            btnRead.Text = "Read File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(428, 273);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(134, 37);
            btnWrite.TabIndex = 6;
            btnWrite.Text = "Write File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // lstNombres
            // 
            lstNombres.Location = new Point(1013, 36);
            lstNombres.Multiline = true;
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(10, 385);
            lstNombres.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(609, 9);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 8;
            label3.Text = "Lista Nombres";
            label3.Click += label3_Click;
            // 
            // lstBoxNombres
            // 
            lstBoxNombres.FormattingEnabled = true;
            lstBoxNombres.Location = new Point(609, 36);
            lstBoxNombres.Name = "lstBoxNombres";
            lstBoxNombres.Size = new Size(398, 394);
            lstBoxNombres.TabIndex = 9;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 461);
            Controls.Add(lstBoxNombres);
            Controls.Add(label3);
            Controls.Add(lstNombres);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Controls.Add(btnNombre);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(lstFile);
            Controls.Add(lblFile);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFile;
        private TextBox lstFile;
        private Label label2;
        private TextBox txtNombre;
        private Button btnNombre;
        private Button btnRead;
        private Button btnWrite;
        private TextBox lstNombres;
        private Label label3;
        private ListBox lstBoxNombres;
    }
}
namespace FundamentosNetCore
{
    partial class Form08StringBuilder
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
            txtChars = new RichTextBox();
            btnString = new Button();
            lblTime = new Label();
            btnStringBuilder = new Button();
            SuspendLayout();
            // 
            // txtChars
            // 
            txtChars.Location = new Point(176, 37);
            txtChars.Name = "txtChars";
            txtChars.Size = new Size(446, 193);
            txtChars.TabIndex = 0;
            txtChars.Text = "";
            // 
            // btnString
            // 
            btnString.Location = new Point(190, 251);
            btnString.Name = "btnString";
            btnString.Size = new Size(203, 33);
            btnString.TabIndex = 1;
            btnString.Text = "button1";
            btnString.UseVisualStyleBackColor = true;
            btnString.Click += btnString_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(545, 323);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(38, 15);
            lblTime.TabIndex = 2;
            lblTime.Text = "label1";
            // 
            // btnStringBuilder
            // 
            btnStringBuilder.Location = new Point(513, 251);
            btnStringBuilder.Name = "btnStringBuilder";
            btnStringBuilder.Size = new Size(203, 33);
            btnStringBuilder.TabIndex = 3;
            btnStringBuilder.Text = "button1";
            btnStringBuilder.UseVisualStyleBackColor = true;
            btnStringBuilder.Click += btnStringBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStringBuilder);
            Controls.Add(lblTime);
            Controls.Add(btnString);
            Controls.Add(txtChars);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtChars;
        private Button btnString;
        private Label lblTime;
        private Button btnStringBuilder;
    }
}
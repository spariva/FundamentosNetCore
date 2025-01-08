namespace FundamentosNetCore
{
    partial class Form09ValidateIsbn
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
            btnValidar = new Button();
            lblResult = new Label();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(330, 267);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "button1";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(272, 328);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 1;
            lblResult.Text = "label1";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(229, 200);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(314, 23);
            txtInput.TabIndex = 2;
            // 
            // Form09ValidateIsbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInput);
            Controls.Add(lblResult);
            Controls.Add(btnValidar);
            Name = "Form09ValidateIsbn";
            Text = "Form09ValidateIsbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private Label lblResult;
        private TextBox txtInput;
    }
}
namespace FundamentosNetCore
{
    partial class Form15Methods
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
            txtN = new TextBox();
            txtL = new TextBox();
            lblRaton = new Label();
            txtNum = new TextBox();
            SuspendLayout();
            // 
            // txtN
            // 
            txtN.Location = new Point(562, 27);
            txtN.Name = "txtN";
            txtN.Size = new Size(100, 23);
            txtN.TabIndex = 0;
            txtN.KeyPress += txtN_KeyPress;
            // 
            // txtL
            // 
            txtL.Location = new Point(562, 83);
            txtL.Name = "txtL";
            txtL.Size = new Size(100, 23);
            txtL.TabIndex = 1;
            txtL.TextChanged += txtL_TextChanged;
            txtL.KeyPress += txtL_KeyPress;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.MediumSpringGreen;
            lblRaton.Location = new Point(562, 149);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(200, 242);
            lblRaton.TabIndex = 2;
            lblRaton.Text = "label1";
            lblRaton.Click += lblRaton_Click;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(87, 21);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 3;
            // 
            // Form15Methods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNum);
            Controls.Add(lblRaton);
            Controls.Add(txtL);
            Controls.Add(txtN);
            Name = "Form15Methods";
            Text = "Form15Methods";
            FormClosed += Form15Methods_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN;
        private TextBox txtL;
        private Label lblRaton;
        private TextBox txtNum;
    }
}
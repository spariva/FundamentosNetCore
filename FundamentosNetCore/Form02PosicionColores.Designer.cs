namespace FundamentosNetCore
{
    partial class Form02PosicionColores
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
            btnColor = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnPosition = new Button();
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            txtColorRed = new TextBox();
            txtColorGreen = new TextBox();
            txtColorBlue = new TextBox();
            SuspendLayout();
            // 
            // btnColor
            // 
            btnColor.Location = new Point(657, 233);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(100, 23);
            btnColor.TabIndex = 0;
            btnColor.Text = "Cambia color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(580, 65);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(580, 130);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(580, 194);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 65);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 130);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // btnPosition
            // 
            btnPosition.Location = new Point(88, 190);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(130, 23);
            btnPosition.TabIndex = 6;
            btnPosition.Text = "Cambia Posicion";
            btnPosition.UseVisualStyleBackColor = true;
            btnPosition.Click += btnPosition_Click;
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(140, 57);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(100, 23);
            txtPosX.TabIndex = 7;
            txtPosX.TextChanged += textBox1_TextChanged;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(140, 122);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(100, 23);
            txtPosY.TabIndex = 8;
            // 
            // txtColorRed
            // 
            txtColorRed.Location = new Point(657, 57);
            txtColorRed.Name = "txtColorRed";
            txtColorRed.Size = new Size(100, 23);
            txtColorRed.TabIndex = 9;
            // 
            // txtColorGreen
            // 
            txtColorGreen.Location = new Point(657, 122);
            txtColorGreen.Name = "txtColorGreen";
            txtColorGreen.Size = new Size(100, 23);
            txtColorGreen.TabIndex = 10;
            // 
            // txtColorBlue
            // 
            txtColorBlue.Location = new Point(657, 186);
            txtColorBlue.Name = "txtColorBlue";
            txtColorBlue.Size = new Size(100, 23);
            txtColorBlue.TabIndex = 11;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 296);
            Controls.Add(txtColorBlue);
            Controls.Add(txtColorGreen);
            Controls.Add(txtColorRed);
            Controls.Add(txtPosY);
            Controls.Add(txtPosX);
            Controls.Add(btnPosition);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnColor);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnColor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnPosition;
        private TextBox txtPosX;
        private TextBox txtPosY;
        private TextBox txtColorRed;
        private TextBox txtColorGreen;
        private TextBox txtColorBlue;
    }
}
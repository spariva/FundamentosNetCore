namespace FundamentosNetCore
{
    partial class Form04DateTime
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
            chkFormato = new CheckBox();
            txtFechaActual = new TextBox();
            groupBox1 = new GroupBox();
            btnIncrementar = new Button();
            txtIncremento = new TextBox();
            rdbAnyos = new RadioButton();
            rdbMeses = new RadioButton();
            rdbDias = new RadioButton();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(108, 90);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(83, 19);
            chkFormato.TabIndex = 0;
            chkFormato.Text = "checkBox1";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(108, 47);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(376, 23);
            txtFechaActual.TabIndex = 1;
            txtFechaActual.TextChanged += txtFechaActual_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(rdbAnyos);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Location = new Point(108, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 243);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(375, 120);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(75, 23);
            btnIncrementar.TabIndex = 4;
            btnIncrementar.Text = "button1";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(375, 89);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(204, 23);
            txtIncremento.TabIndex = 3;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(30, 122);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(94, 19);
            rdbAnyos.TabIndex = 2;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "radioButton1";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(30, 77);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(94, 19);
            rdbMeses.TabIndex = 1;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "radioButton1";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(30, 34);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(94, 19);
            rdbDias.TabIndex = 0;
            rdbDias.TabStop = true;
            rdbDias.Text = "radioButton1";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(108, 374);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(376, 23);
            txtNuevaFecha.TabIndex = 4;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNuevaFecha);
            Controls.Add(groupBox1);
            Controls.Add(txtFechaActual);
            Controls.Add(chkFormato);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkFormato;
        private TextBox txtFechaActual;
        private GroupBox groupBox1;
        private Button btnIncrementar;
        private TextBox txtIncremento;
        private RadioButton rdbAnyos;
        private RadioButton rdbMeses;
        private RadioButton rdbDias;
        private TextBox txtNuevaFecha;
    }
}
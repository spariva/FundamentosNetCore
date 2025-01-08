namespace FundamentosNetCore
{
    partial class Form11Listas
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
            btnInsert = new Button();
            btnEliminar = new Button();
            btnEliminarTodo = new Button();
            lstElementos = new ListBox();
            txtInput = new TextBox();
            lblResult = new Label();
            btnSeleccion = new Button();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(507, 86);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 23);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(507, 168);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 23);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar selected";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEliminarTodo
            // 
            btnEliminarTodo.Location = new Point(507, 250);
            btnEliminarTodo.Name = "btnEliminarTodo";
            btnEliminarTodo.Size = new Size(121, 23);
            btnEliminarTodo.TabIndex = 2;
            btnEliminarTodo.Text = "Borrar Todo";
            btnEliminarTodo.UseVisualStyleBackColor = true;
            btnEliminarTodo.Click += btnEliminarTodo_Click;
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(49, 48);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(293, 319);
            lstElementos.TabIndex = 3;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(475, 24);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(153, 23);
            txtInput.TabIndex = 4;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(538, 344);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(39, 15);
            lblResult.TabIndex = 5;
            lblResult.Text = "Result";
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(382, 80);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(75, 23);
            btnSeleccion.TabIndex = 6;
            btnSeleccion.Text = "Seleccionados";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // Form11Listas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccion);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(lstElementos);
            Controls.Add(btnEliminarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsert);
            Name = "Form11Listas";
            Text = "Form11Listas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private Button btnEliminar;
        private Button btnEliminarTodo;
        private ListBox lstElementos;
        private TextBox txtInput;
        private Label lblResult;
        private Button btnSeleccion;
    }
}
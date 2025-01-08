using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form16ArrayList : Form
    {
        public Form16ArrayList()
        {
            InitializeComponent();
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);

            ((Button)coleccion[0]).BackColor = Color.Azure;
            int i = 0;
            foreach (Button boton in coleccion)
            {
                i++;
                boton.Text = "Botón " + i;
            }

            this.button1.Click += MetodoDelegado;

            //SI TENGO OBJETOS DE CLASES DISTINTAS, DEBEMOS 
            //ABSTRAERNOS
            foreach (Control control in coleccion)
            {
                control.BackColor = Color.LightGreen;
                //LA CLASE TEXTBOX CONTIENE UN METODO Paste()
                //PARA PEGAR EL CONTENIDO DEL PORTAPAPELES EN 
                //EL INTERIOR DEL CONTROL.
                //DEBEMOS PREGUNTAR POR EL TIPO DEL CONTROL
                if (control is TextBox)
                {
                    ((TextBox)control).Paste();
                }
            }

        }

        void MetodoDelegado(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click");
        }

        private void Form16ArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}

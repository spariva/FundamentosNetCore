using System;
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
    public partial class Form17Listas : Form
    {
        int contador;
        List<Button> botones;

        public Form17Listas()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            this.button1.Click += BotonPulsado;
            this.botones.Add(this.button1);
            this.botones.Add(this.button2);
            this.botones.Add(this.button3);
            this.botones.Add(this.button4);
            foreach (Button boton in this.botones)
            {
                boton.Click += BotonPulsado;
            }

        }

        private void Form17Listas_Load(object sender, EventArgs e)
        {

        }

        void BotonPulsado(object sender, EventArgs e)
        {
            this.contador++;
            this.txtInput.Text = this.contador.ToString();
            Button miBoton = (Button)sender;
            miBoton.BackColor = Color.Red;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

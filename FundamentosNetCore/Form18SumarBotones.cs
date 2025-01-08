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
    public partial class Form18SumarBotones : Form
    {
        List<Button> botones;
        int suma;

        public Form18SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.suma = 0;

            foreach (Button boton in this.panel1.Controls)
            {
                this.botones.Add(boton);
                boton.Click += SumarNumeros;
            }
        }

        void SumarNumeros(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            this.suma += numero;
            this.textBox1.Text = this.suma.ToString();
        }

        private void Form18SumarBotones_Load(object sender, EventArgs e)
        {

        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.textBox1.Text = suma.ToString();

            foreach (Button boton in this.botones)
            {
                int numRandom = random.Next(1, 99);
                boton.Text = numRandom.ToString();
                this.suma += numRandom;
            }
        }
    }
}

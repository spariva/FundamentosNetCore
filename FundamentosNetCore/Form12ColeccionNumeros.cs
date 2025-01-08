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
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int numero = random.Next(1, 100);
                this.lstNum.Items.Add(numero);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int resta = 0;
            foreach (var item in this.lstNum.Items)
            {
                int numero = Convert.ToInt32(item);
                suma += numero;
                resta -= numero;
                if (numero % 2 != 0)
                {
                    this.txtImpares.Text += numero + ", ";
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtResta.Text = resta.ToString();


        }

        private void txtSuma_TextChanged(object sender, EventArgs e)
        {


        }
    }
}

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
    public partial class Form07SumarNumerosString : Form
    {
        public Form07SumarNumerosString()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string textoNumeros = txtNum.Text;
            int suma = 0;
            for (int i = 0; i < textoNumeros.Length; i++)
            {
                char caracter = textoNumeros[i];
                //int nums = Convert.ToInt32(caracter.ToString());
                int numero = int.Parse(caracter.ToString());
                suma += numero;
            }
            this.lblResult.Text = suma.ToString();
        }
    }
}

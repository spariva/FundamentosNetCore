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
    public partial class Form09ValidateIsbn : Form
    {
        public Form09ValidateIsbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = this.txtInput.Text;
            int suma = 0;

            if (isbn.Length != 10)
            {
                this.lblResult.Text = "El ISBN debe tener 10 caracteres";
                return;
            }

            for (int i = 0; i < isbn.Length; i++)
            {
                char numchar = isbn[i];
                int num = int.Parse(numchar.ToString());
                suma += num * (i + 1);
            }

            if (suma % 11 == 0)
            {
                this.lblResult.Text = "ISBN Correcto";
            }
            else
            {
                this.lblResult.Text = "ISBN Incorrecto";
            }
        }
    }
}

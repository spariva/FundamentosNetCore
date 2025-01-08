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
    public partial class Form19Checkbox : Form
    {
        int suma;
        List<CheckBox> checkboxes;
        public Form19Checkbox()
        {
            InitializeComponent();
            suma = 0;
            checkboxes = new List<CheckBox>();

            foreach (CheckBox checkbox in this.panel1.Controls)
            {
                checkboxes.Add(checkbox);
                checkbox.CheckedChanged += SumarNumeros;
            }
        }

        void SumarNumeros(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            int numero = int.Parse(chk.Text);
            if (chk.Checked)
            {
                this.suma += numero;
            }
            else
            {
                this.suma -= numero;
            }
            this.lblResult.Text = this.suma.ToString();
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.lblResult.Text = suma.ToString();

            foreach (CheckBox chk in this.checkboxes)
            {
                int numRandom = random.Next(1, 99);
                chk.Text = numRandom.ToString();
                this.suma += numRandom;
            }
        }
    }
}

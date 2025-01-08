using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {

        }

        private void btnString_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            string cadena = this.txtChars.Text;
            int longitud = cadena.Length;
            sw.Start();
            for (int i = 0; i < longitud; i++)
            {
                char letra = cadena[longitud - 1];
                cadena = cadena.Substring(0, longitud - 1);
                cadena = cadena.Insert(i, letra.ToString());
            }
            this.txtChars.Text = cadena;
            sw.Stop();
            this.lblTime.Text = sw.ElapsedMilliseconds.ToString();
        }
    }
}

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
    public partial class Form15Methods : Form
    {
        public Form15Methods()
        {
            InitializeComponent();
        }

        private void lblRaton_Click(object sender, EventArgs e)
        {

        }

        private void Form15Methods_FormClosed(object sender, FormClosedEventArgs e)
        {
            e.CloseReason.ToString();
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + " Y: " + e.Y;
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void txtL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtL_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}

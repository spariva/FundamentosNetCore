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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            this.btnPosition.Location = new Point(int.Parse(this.txtPosX.Text), int.Parse(this.txtPosY.Text));
            this.btnPosition.Text = this.txtPosX.Text + ", " + this.txtPosY.Text;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int red = int.Parse(this.txtColorRed.Text);
            int green = int.Parse(this.txtColorGreen.Text);
            int blue = int.Parse(this.txtColorBlue.Text);

            if(red < 0 || red > 255)
            {
                MessageBox.Show("El valor de rojo debe estar entre 0 y 255");
                return;
            }

            this.txtColorRed.Text = red.ToString();
            this.txtColorGreen.Text = green.ToString();
            this.txtColorBlue.Text = blue.ToString();
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}

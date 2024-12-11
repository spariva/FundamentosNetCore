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
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anio = int.Parse(this.txtAnyo.Text);

            if (mes == 1 || mes == 2)
            {
                mes += 12;
                anio--;
            }

            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anio / 4;
            int op3 = anio / 100;
            int op4 = anio / 400;
            int op5 = dia + (mes * 2) + anio + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int op8 = op5 - (op6 * 7);
            string diaSemana = "";

            switch (op8)
            {
                case 0:
                    diaSemana = "Sábado";
                    break;
                case 1:
                    diaSemana = "Domingo";
                    break;
                case 2:
                    diaSemana = "Lunes";
                    break;
                case 3:
                    diaSemana = "Martes";
                    break;
                case 4:
                    diaSemana = "Miércoles";
                    break;
                case 5:
                    diaSemana = "Jueves";
                    break;
                case 6:
                    diaSemana = "Viernes";
                    break;
                case 7:
                    diaSemana = "Sábado";
                    break;
                default:
                    break;
            }

            lblDiaSemana.Text = diaSemana;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosNetCore
{
    public partial class Form21Empleado : Form
    {
        public Form21Empleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "Kai";
            empleado.Apellidos = "V. M.";
            this.listBox1.Items.Add(empleado.GetNombreCompleto() + empleado.SalarioMinimo);

            Director dire = new Director();
            dire.Nombre = "Kaima";
            dire.Apellidos = "V. M.";
            this.listBox1.Items.Add(dire.GetNombreCompleto() + dire.SalarioMinimo);

        }
    }
}

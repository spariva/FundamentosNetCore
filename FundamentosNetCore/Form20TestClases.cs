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
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Kai";
            persona.Apellido = "V. M.";
            persona.Edad = 33;
            persona.Genero = TipoGenero.NB;
            persona.Nacionalidad = Paises.Colombia;
            persona.Domicilio = new Direccion("Calle 123", "Bogotá");
            persona.DomicilioVacaciones = new Direccion("Calle 456", "Medellín", 12345);

            this.listBox1.Items.Add("Nombre: " + persona.Nombre 
                + ", Apellidos: " + persona.Apellido);
            this.listBox1.Items.Add("Edad: " + persona.Edad);
            this.listBox1.Items.Add("Genero: " + persona.Genero);

            this.listBox1.Items.Add(persona.ObtenerNombreCompleto());
            this.listBox1.Items.Add("Nacionalidad: " + persona.Nacionalidad);
            this.listBox1.Items.Add("Domicilio: " + persona.Domicilio.Calle + ", " + persona.Domicilio.Ciudad);
        }
    }
}

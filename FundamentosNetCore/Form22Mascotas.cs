using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases.Helpers;
using ProyectoClases.Models;

namespace FundamentosNetCore
{
    public partial class Form22Mascotas : Form
    {
        private HelperMascotas helper;
        public Form22Mascotas()
        {
            InitializeComponent();
            this.helper = new HelperMascotas("mascotas.txt");
        }

        private void DibujarMascotas()
        {
            this.listBox1.Items.Clear();
            foreach (Mascota mascota in this.helper.Mascotas)
            {
                this.listBox1.Items.Add(mascota.Nombre + " - " + mascota.Raza);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creamos una mascota
            Mascota m = new Mascota();
            m.Nombre = this.txtNombre.Text;
            m.Raza = this.txtRaza.Text;
            this.helper.Mascotas.Add(m);
            this.DibujarMascotas();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await this.helper.ReadMascotasAsync();
            this.DibujarMascotas();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await this.helper.WriteMascotasAsync();
            this.listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            Mascota m = this.helper.Mascotas[index];
            this.txtNombre.Text = m.Nombre;
            this.txtRaza.Text = m.Raza;
        }
    }
}

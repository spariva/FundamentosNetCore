using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;

namespace FundamentosNetCore
{
    public partial class Form21Files : Form
    {
        private string Path { get; set; }

        public Form21Files()
        {
            InitializeComponent();
            this.Path = @"C:\Users\Alumnos MCSD Mañana\Desktop\NetCore\FundamentosNetCore\FundamentosNetCore\bin\Debug\file1.txt";
            this.Path = "file1.txt";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            this.lstBoxNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();

        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstBoxNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            //nos devuelve un file y podemos crear writer o reader
            FileInfo file = new FileInfo(this.Path);
            //creamos el fichero
            using (TextWriter writer = file.CreateText())
            {
                //obtenemos los nombres de la lista
                string data = this.GetNombresListBox();
                //escribimos en el fichero
                await writer.WriteAsync(data);
                //siempre flush
                await writer.FlushAsync();
                //cerramos el writer
                writer.Close();
                MessageBox.Show("Fichero guardado");
            }
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.Path);
            if (file.Exists)
            {
                using (TextReader reader = file.OpenText())
                {
                    string data = await reader.ReadToEndAsync();
                    reader.Close();
                    this.lstFile.Text = data;
                    //string[] nombres = data.Split(',');
                    //foreach (string nombre in nombres)
                    //{
                    //    this.lstBoxNombres.Items.Add(nombre);
                    //}
                }
            }
            else
            {
                MessageBox.Show("Fichero no existe");
            }
        }
    }
}

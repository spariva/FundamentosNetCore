using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        private string Path;
        public List<Mascota> Mascotas { get; set; }


        public HelperMascotas(string path)
        {
            this.Path = path;
            this.Mascotas = new List<Mascota>();
        }

        private string MascotasToString()
        {
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                data += mascota.Nombre + "," + mascota.Raza + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }

        private void MascotaStringToList(string data)
        {
            this.Mascotas.Clear();
            string[] datosMascotas = data.Split('@');
            foreach (string stringMascota in datosMascotas)
            {
                string[] propiedades = stringMascota.Split(',');
                Mascota m = new Mascota();
                m.Nombre = propiedades[0];
                m.Raza = propiedades[1];
                this.Mascotas.Add(m);
            }
        }

        public async Task WriteMascotasAsync()
        {
            string data = this.MascotasToString();
            await HelperFiles.WriteFileAsync(this.Path, data);
        }

        public async Task ReadMascotasAsync()
        {
            string data = await HelperFiles.ReadFileAsync(this.Path);
            this.MascotaStringToList(data);
        }















    }
}

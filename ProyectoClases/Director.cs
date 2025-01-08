using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director()
        {
            this.SalarioMinimo += 200;
        }

        //SOBREESCRITO (virtual/override) o (new)
        public override int GetDiasVacaciones()
        {
            Debug.WriteLine("Días de vacaciones para un director");
            int vacacionesBase = base.GetDiasVacaciones();
            return vacacionesBase + 8;
        }

        //IMPLEMENTADO
        public int GetDiasVacaciones(int extras) 
        {
            return this.GetDiasVacaciones() + extras;
        }
    }
}

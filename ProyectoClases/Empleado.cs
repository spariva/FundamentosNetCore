using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        protected int SalarioMinimo { get; set; }

        public Empleado()
        {
            this.SalarioMinimo = 1000;
        }

        public int getSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public virtual int GetDiasVacaciones()
        {
            return 22;
        }
    }
}

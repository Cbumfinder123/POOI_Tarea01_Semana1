using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    internal class Empleado
    {
        public int codigo {  get; set; }
        public string nombre { get; set; }
        public int numerocel { get; set; }
        public double sueldo { get; set; }

        public Empleado(int codigo, string nombre, int numerocel, double sueldo)
        {
            this.codigo=codigo;
            this.nombre=nombre;
            this.numerocel=numerocel;
            this.sueldo=sueldo;
        }

        public string Sueldo()
        {
            if(sueldo > 3500)
            {
                return "mayor a 3500";
            }
            else if (sueldo < 3500)
            {
                return "menor a 3500";
            }
            else
            {
                return "igual a 3500";
            }
        }
    }
}

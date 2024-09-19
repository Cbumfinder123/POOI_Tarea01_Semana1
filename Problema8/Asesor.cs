using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema8
{
    internal class Asesor
    {
        public int codigo {  get; set; }
        public string nombre { get; set; }
        public int horas { get; set; }
        public double tarifa { get; set; }

        public Asesor(int codigo, string nombre, int horas, double tarifa)
        {
            this.codigo=codigo;
            this.nombre=nombre;
            this.horas=horas;
            this.tarifa=tarifa;
        }

        public double SueldoBruto()
        {
            return horas * tarifa;
        }
        public double Descuento()
        {
            return SueldoBruto() * 0.15;
        }

        public double SueldoNeto()
        {
            return SueldoBruto() - Descuento();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    internal class Obrero
    {
        public int codigo {  get; set; }
        public string nombre { get; set; }  
        public int horas { get; set; }
        public double tarifa { get; set; }

        public Obrero(int codigo, string nombre, int horas, double tarifa)
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
        public double DescuentoAFP()
        {
            return SueldoBruto() * 0.10;
        }
        public double DescuentoEPS()
        {
            return SueldoBruto() * 0.05;
        }
        public double SueldoNeto()
        {
            return SueldoBruto() - DescuentoAFP() - DescuentoEPS();
        }
    }
}

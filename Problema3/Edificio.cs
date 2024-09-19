using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    internal class Edificio
    {
        public int codigo {  get; set; }
        public int numero { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }

        public Edificio(int codigo, int numero, int cantidad, double precio)
        {
            this.codigo=codigo;
            this.numero=numero;
            this.cantidad=cantidad;
            this.precio=precio;
        }

        public double CalcularPrecioEdificio()
        {
            return numero * precio;
        }
    }
}

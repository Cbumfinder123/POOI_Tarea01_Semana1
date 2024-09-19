using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    internal class Pelota
    {
        public string marca {  get; set; }
        public double gramos { get; set; }
        public double presionLibras { get; set; }
        public double diametro { get; set; }
        public double precio { get; set; }

        public Pelota(string marca, double gramos, double presionLibras, double diametro, double precio)
        {
            this.marca=marca;
            this.gramos=gramos;
            this.presionLibras=presionLibras;
            this.diametro=diametro;
            this.precio=precio;
        }

        public double CalcularRadio()
        {
            return diametro/2;
        }

        public double CalcularVolumen()
        {
            double radio = CalcularRadio();
            return (4* 3.1416 * Math.Pow(radio, 3))/3;
        }
        public double CalcularDescuento()
        {
            return precio * 0.10;
        }
        public double ImporteApagar()
        {
            return precio - CalcularDescuento();
        }
    }

}

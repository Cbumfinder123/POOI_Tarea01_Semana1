using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    internal class Video
    {
        public int codigo {  get; set; }
        public string nombre { get; set; }
        public double duracion { get; set; }
        public double precioSoles { get; set; }
        public double tipoCambio { get; set; }

        public Video(int codigo, string nombre, double duracion, double precioSoles, double tipoCambio)
        {
            this.codigo=codigo;
            this.nombre=nombre;
            this.duracion=duracion;
            this.precioSoles=precioSoles;
            this.tipoCambio=tipoCambio;
        }

        public double PrecioDolares()
        {
            return precioSoles / tipoCambio;
        }
    }
}

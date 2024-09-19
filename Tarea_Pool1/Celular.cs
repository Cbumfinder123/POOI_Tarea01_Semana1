using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pool1
{
    internal class Celular
    {
     
        public int numero {  get; set; }
        public string usuario { get; set; }
        public int segundos { get; set; }
        public double precio { get; set; }

        public Celular(int numero, string usuario, int segundos, double precio)
        {
            this.numero=numero;
            this.usuario=usuario;
            this.segundos=segundos;
            this.precio=precio;
        }
        

        public double calcularCosto()
        {
            return segundos * precio;
        }

        public double calcularIGV()
        {
            return calcularCosto() * 0.18;
        }

        public double calcularTotal()
        {
            return calcularCosto() + calcularIGV();
        }

    }
}

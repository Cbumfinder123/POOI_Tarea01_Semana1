using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Edificio ed = new Edificio(123,10,5,100000);
            Listar(ed);

            Console.WriteLine("----------------------------------");
            ed.precio *= 1.20;
            Listar(ed);

            Console.ReadKey();
        }
        public static void Listar(Edificio ed)
        {
            Console.WriteLine("codigo:"+ ed.codigo);
            Console.WriteLine("Numero de Departamentos:"+ ed.numero);
            Console.WriteLine("Cantidad de Pisos:"+ ed.cantidad);
            Console.WriteLine("Precio de un Departamento : $"+ ed.precio);
            Console.WriteLine("Precio Total del Edificio : $"+ ed.CalcularPrecioEdificio());
        }
    }
}

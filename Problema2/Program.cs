using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora com = new Computadora(123, "ASUS", "Blanco", 1000);
            List(com);
            com.precio *= 0.90;
            List(com);

            Console.ReadKey();
        }
        public static void List(Computadora com)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Codigo:"+ com.codigo);
            Console.WriteLine("Marca:"+ com.marca);
            Console.WriteLine("Color:" + com.color);
            Console.WriteLine("Precio en Dolares:"+ com.precio);
            Console.WriteLine("Precio en Soles:"+ com.calcularPrecioS());
            Console.WriteLine("Precio en Euros:"+ com.calcularPrecioE());
        }
    }
}

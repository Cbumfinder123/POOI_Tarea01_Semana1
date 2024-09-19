using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota pelo = new Pelota("Adidas",300,7.5,20,90);
            Listar(pelo);

            Console.WriteLine("-------------------------------");
            pelo.precio *= 0.75;
            pelo.diametro += 1;
            Listar(pelo);
            Console.ReadKey();

        }
        public static void Listar(Pelota pelo)
        {
            Console.WriteLine("Marca:"+ pelo.marca);
            Console.WriteLine("Peso:"+ pelo.gramos);
            Console.WriteLine("Presion:"+ pelo.presionLibras);
            Console.WriteLine("Diametro:"+ pelo.diametro);
            Console.WriteLine("Precio:"+ pelo.precio);
            Console.WriteLine("Radio:"+ pelo.CalcularRadio());
            Console.WriteLine("Volumen:"+ pelo.CalcularVolumen());
            Console.WriteLine("Descuento:"+ pelo.CalcularDescuento());
            Console.WriteLine("Importe a pagar:"+ pelo.ImporteApagar());
        }
    }
}

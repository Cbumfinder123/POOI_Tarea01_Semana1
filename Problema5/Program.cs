using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video vid = new Video(123,"Documental",2.5,50.0,3.7);
            Listar(vid);

            Console.WriteLine("-----------------------------");

            vid.precioSoles += 5.50;
            Listar(vid);

            Console.ReadKey();
        }
        static void Listar(Video vid)
        {
            Console.WriteLine("Codigo:"+ vid.codigo);
            Console.WriteLine("Nombre del Video:"+ vid.nombre);
            Console.WriteLine("Duracion:"+ vid.duracion);
            Console.WriteLine("Precio en Soles:"+ vid.precioSoles);
            Console.WriteLine("Tipo de Cambio:"+ vid.tipoCambio);
            Console.WriteLine("Precio en Dolares:"+ vid.PrecioDolares());

        }

    }
}

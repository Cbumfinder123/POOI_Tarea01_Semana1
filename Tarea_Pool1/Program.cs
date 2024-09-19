using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Pool1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular cell = new Celular(952369996,"Rodrigo",400,0.10);
            List(cell);

            cell.segundos += 20;
            cell.precio *= 0.95;
            List(cell);

            Console.ReadKey();
        }

        public static void List(Celular cell)
        {
            Console.WriteLine("Numero :"+ cell.numero);
            Console.WriteLine("Usuario :"+ cell.usuario);
            Console.WriteLine("Segundos Consumidos :"+ cell.segundos);
            Console.WriteLine("Precio por Segundo :" + cell.precio);
            Console.WriteLine("Costo por Consumo :" + cell.calcularCosto());
            Console.WriteLine("Impuestos IGV :" + cell.calcularIGV());
            Console.WriteLine("Total a Pagar :" + cell.calcularTotal());
            Console.WriteLine();
        }
    }
}

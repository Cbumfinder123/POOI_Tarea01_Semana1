using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado(01,"Nick",992129992,3400);
            Listar(emp);

            Console.WriteLine("-------------------------------");

            emp.numerocel = 999888777;
            emp.sueldo += 200;
            Listar(emp);

            Console.ReadKey();

        }
        public static void Listar(Empleado emp)
        {
            Console.WriteLine("Codigo:"+ emp.codigo);
            Console.WriteLine("Nombre:"+ emp.nombre);
            Console.WriteLine("Numero de Celular:"+ emp.numerocel);
            Console.WriteLine("Sueldo:"+ emp.sueldo + "(" + emp.Sueldo() + ")"); 
        }
    }
}

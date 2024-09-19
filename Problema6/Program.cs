using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente pac = new Paciente("Nicolas","Fernandez",17,1.70,80.5);
            Listar(pac);

            Console.WriteLine("---------------------------");

            pac.edad = 20;
            Listar(pac);

            Console.ReadKey();
        }

        public static void Listar(Paciente pac)
        {
            Console.WriteLine("Nombre:"+ pac.nombre);
            Console.WriteLine("Apellido:"+ pac.apellido );
            Console.WriteLine("Edad:"+ pac.edad + "(" + pac.MayorEdad() + ")");
            Console.WriteLine("Talla:"+ pac.talla);
            Console.WriteLine("Peso:"+ pac.peso);

        }
    }
}

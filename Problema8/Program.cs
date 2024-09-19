using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor ase = new Asesor(01,"Nicolas",40,50.0);
            Listar(ase);

            Console.WriteLine("-------------------------------");

            ase.horas += 10;
            ase.tarifa *= 0.85;
            Listar(ase);    

            Console.ReadKey();
        }
        public static void Listar(Asesor ase)
        {
            Console.WriteLine("Codigo:"+ ase.codigo);
            Console.WriteLine("Nombre:"+ ase.nombre);
            Console.WriteLine("Horas trabajadas:"+ ase.horas);
            Console.WriteLine("Tarifa por Hora:"+ ase.tarifa);
            Console.WriteLine("Sueldo Bruto:"+ ase.SueldoBruto());
            Console.WriteLine("Descuento:"+ ase.Descuento());
            Console.WriteLine("Sueldo Neto:"+ ase.SueldoNeto());
        }
    }
}

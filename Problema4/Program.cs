using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero obre = new Obrero(123,"Nicolas",30,15.0);
            Listar(obre);

            Console.WriteLine("-----------------------------");

            obre.horas +=8;
            obre.tarifa *= 0.985;
            Listar(obre);


            Console.ReadKey();
        }
        public static void Listar(Obrero obre)
        {
            Console.WriteLine("Codigo:"+ obre.codigo);
            Console.WriteLine("Nombre:"+ obre.nombre);
            Console.WriteLine("Horas trabajadas:"+ obre.horas);
            Console.WriteLine("Tarifa por Hora :"+ obre.tarifa);
            Console.WriteLine("Sueldo Bruto:"+ obre.SueldoBruto());
            Console.WriteLine("Descuento AFP:"+ obre.DescuentoAFP());
            Console.WriteLine("Descuento EPS:"+ obre.DescuentoEPS());
            Console.WriteLine("Sueldo Neto:"+ obre.SueldoNeto());
        }
    }

}

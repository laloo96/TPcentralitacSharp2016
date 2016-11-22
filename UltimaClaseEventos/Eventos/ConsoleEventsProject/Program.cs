using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEventsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            miClase personita = new miClase();
         
            personita.noEsLaEdad += Program.juna;

            personita.esLaEdad(10);

            Console.ReadKey();
        }

        public static void juna(int edad)
        {
            Console.WriteLine("La edad no coincide.");
        }
    }
}

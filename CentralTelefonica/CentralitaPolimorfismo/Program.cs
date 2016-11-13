using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita telefonica = new Centralita("Telefonica SA");

            Local unaLocal = new Local("Chaco", 30, "SanJuan", (float)2.65);

            Provincial unaProvincial = new Provincial("misiones", (eFranja)1, 21, "Lima");

            Local dosLocal = new Local("Areco", 45, "Cataratas", (float)1.99);

            Provincial dosProvincial = new Provincial((eFranja)3, unaProvincial);

            telefonica += unaLocal;
            telefonica += unaProvincial;
            telefonica += unaProvincial;
            telefonica += dosLocal;
            telefonica += dosProvincial;

            Console.WriteLine(telefonica.ToString());

            Console.WriteLine("------------------Cargo MAS LLamadas---------------");

            Local tresLocal = new Local("Santiago", 50, "Rusia", (float)6.3);
            Provincial tresProvincial = new Provincial("Ecuador", (eFranja)2, 15, "Sao Pablo");

            telefonica += tresLocal;
            telefonica += tresProvincial;
            telefonica += tresProvincial;

            telefonica.OrdenarLlamadas();

            Console.WriteLine(telefonica.ToString());

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main()
        {
            Centralita telefonica = new Centralita();

            Local unaLocal = new Local("Chaco", 30, "SanJuan", (float)2.65);

            Provincial unaProvincial = new Provincial("misiones", (eFranja)1, 21, "Lima");

            Local dosLocal = new Local("Areco", 45, "Cataratas", (float)1.99);

            Provincial dosProvincial = new Provincial((eFranja)3, unaProvincial);

            telefonica.Llamada.Add(unaLocal);
            telefonica.Llamada.Add(unaProvincial);
            telefonica.Llamada.Add(dosLocal);
            telefonica.Llamada.Add(dosProvincial);

            Console.WriteLine(telefonica.Mostrar());

            Console.WriteLine("------------------Cargo MAS LLamadas---------------");

            Local tresLocal = new Local("Santiago", 50, "Rusia", (float)6.3);
            Provincial tresProvincial = new Provincial("Ecuador", (eFranja)2, 15, "Sao Pablo");

            telefonica.Llamada.Add(tresLocal);
            telefonica.Llamada.Add(tresProvincial);

            telefonica.OrdenarLlamadas();
            Console.WriteLine(telefonica.Mostrar());

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace CentralitaSerializacion
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

            bool succed = true;

            try
            {
                telefonica += unaLocal;
                telefonica += unaProvincial;
                telefonica += dosLocal;
                telefonica += dosProvincial;
                telefonica += dosProvincial;
                telefonica.RutaDelArchivo = "Centralita.xml";
                succed = telefonica.DeSerialize();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }



            Console.WriteLine("Leyo xml: " + succed.ToString());
            Console.Write("");

            telefonica.RutaDelArchivo = "Centralita.xml";
            succed = telefonica.Serialize();
            Console.WriteLine("Serializo: "+ succed.ToString());


            Console.WriteLine(telefonica.ToString());

            Console.ReadKey();
        
        }
    }
}

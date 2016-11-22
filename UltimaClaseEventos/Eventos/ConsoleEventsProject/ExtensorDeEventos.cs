using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEventsProject
{
    //La clase debe ser, si o si, satatic.
    public static class ExtensorDeEventos
    {
        //Metodo de extension.      //firma = public static RETORNO NOMBRE (this->CUALQUIERCLASE parametro).
        public static void miMetodo(this string  dato)                     //Se refiere a la calse.
        {
            Console.WriteLine(dato);
        }
    }
}

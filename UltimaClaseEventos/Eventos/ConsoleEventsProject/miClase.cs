using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEventsProject
{
    //Creo el delegado.
    public delegate void miDelegado(int edad);
    public class miClase
    {
        public int edad;

        //Creo el evento.
        public event miDelegado noEsLaEdad;

        //Metodo que dispara el evento.
        public void esLaEdad(int edad)
        {
            if (this.edad != edad)
            {
                noEsLaEdad(edad);
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEventsProject
{
    public delegate void miDelegado(int edad);
    public class miClase
    {
        public int edad;

        public void esLaEdad(int edad)
        {
            if (this.edad != edad)
            {
                noEsLaEdad(edad);
            }
        }

        public event miDelegado noEsLaEdad;
    }
}

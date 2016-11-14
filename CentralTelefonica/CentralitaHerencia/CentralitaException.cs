using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class CentralitaException:Exception
    {
        private Exception _excepcionInterna;
        private string _nombreClase;
        private string _nombreMetodo;

        public Exception ExcepcionInterna
        {
            get
            {
                return _excepcionInterna;
            }
        }

        public string NombreClase
        {
            get
            {
                return _nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return _nombreMetodo;
            }
        }

        public CentralitaException(string mensaje, string clase, string metodo)
        {

        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
        {

        }


    }
}

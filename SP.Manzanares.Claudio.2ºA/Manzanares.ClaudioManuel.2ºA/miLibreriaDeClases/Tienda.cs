using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Excepciones;

namespace miLibreriaDeClases
{
    public class Tienda:Local,IArchivos<string>
    {
        public Tienda(string direccion, string anchofrente, string legajo)
            :base(direccion,anchofrente,legajo)
        {
            
        }

        protected override string Legajo
        {
            get
            {
                return legajo;
            }
            set
            {
                this.legajo = value;
            }
        }




        public string ExponerDatos(Local store)
        {
            return base.ToString();
        }

        public bool Guardar(string ruta)
        {
            bool succed = false;

            try
            {
                using (StreamWriter escritor = new StreamWriter(ruta,true))
                {
                    escritor.Write(this.ExponerDatos(this));
                    succed = true;
                }
            }
            catch (Exception e)
            {
                throw new NoGuardaException("Error al intentar guardar archivo.", e);          
            }

            return succed;
        }

        public bool Leer(string ruta, out string datos)
        {
            bool succed = false;

            try
            {
                using(StreamReader lector = new StreamReader(ruta))
                {
                    datos = lector.ReadToEnd();
                    succed = true;
                }		 
	        }
            catch (Exception)
            {
                
                throw new NoGuardaException("Eror al intentar leer desde el archivo.");
            }

            return succed;
        }
        
        public bool IsNotIllegalNumber(string ancho)
        {
            int numero=0;

            if(int.TryParse(ancho,out numero))
            {
                if (numero < 0 || numero / 2 != 0)
                    throw new Exception("Numero impar o negativo.");
                else
                    return true;
            }

            return false;
        }
    }
}

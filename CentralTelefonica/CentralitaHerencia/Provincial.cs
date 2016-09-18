using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        protected Franja _franjaHoraria; 

        public float costoLlamada
        {
            get
            {
                return this.costoLlamada;
            }
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
        {
            this._nroOrigen = origen;
            this._duracion = duracion;
            this._nroDestino = destino;
            this._franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada unaLlamada):this(unaLlamada.nroOrigen,miFranja,unaLlamada.duracion,unaLlamada.nroDestino)
        {       }

        private float ClacularCosto()
        {
            return 0;
        }

        private float CalcularCosto()
        {
            switch (this._franjaHoraria.ToString())
            {
                
            }
        }
    }
}

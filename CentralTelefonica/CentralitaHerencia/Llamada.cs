using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public Llamada(float duracion,string origen,string destino)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }

        public float duracion
        {
            get
            {
            return this._duracion;
            }
        }

        public string nroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string nroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        public static int OrdenarPorDuracion(Llamada firstCall, Llamada secondCall)
        {
            return string.Compare(firstCall.duracion.ToString(), secondCall.duracion.ToString());
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append("Duracion: "+this.duracion.ToString());
            str.Append(" Nro.Origen: " + this.nroOrigen.ToString());
            str.Append(" Nro.Destino: " + this.nroDestino.ToString());

            return str.ToString();
        }
    }
}

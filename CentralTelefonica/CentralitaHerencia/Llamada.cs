using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CentralitaHerencia
{
    [Serializable]
    [XmlInclude(typeof(Local))]
    [XmlInclude(typeof(Provincial))]
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public Llamada()
        {

        }

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

        public abstract float CostoLlamada { get; }


        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen)
            {
                if (l1.GetType() == typeof(Provincial))
                {
                    return ((Provincial)l1).Equals(l2);
                }
                else if (l2.GetType() == typeof(Local))
                {
                    return ((Local)l1).Equals(l2);
                }
                else
                   return false;
               
            }
            else
                return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public static int OrdenarPorDuracion(Llamada firstCall, Llamada secondCall)
        {
            return string.Compare(firstCall.duracion.ToString(), secondCall.duracion.ToString());
        }

        protected virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append("Duracion: "+this.duracion.ToString());
            str.Append(" Nro.Origen: " + this.nroOrigen.ToString());
            str.Append(" Nro.Destino: " + this.nroDestino.ToString());

            return str.ToString();
        }

    }
}

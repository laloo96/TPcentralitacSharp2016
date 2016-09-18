using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected float _costo;

        public Local(string origen,float duracion,string destino,float costo)
            :base(duracion,origen,destino)
        {
            this._costo = costo;
        }

        public Local(Llamada unaLlamada,float costo)
            :this(unaLlamada.nroOrigen,unaLlamada.duracion,unaLlamada.nroDestino,costo)
        {

        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append("Duracion: " + this.duracion.ToString());
            str.Append(" Nro.Origen: " + this.nroOrigen.ToString());
            str.Append(" Nro.Destino: " + this.nroDestino.ToString());
            str.Append(" Costo Llamada: " + this.CostoLlamada.ToString());

            return str.ToString();
        }

        private float CalcularCosto()
        {
            return this._costo * this.duracion;
        }
    }
}

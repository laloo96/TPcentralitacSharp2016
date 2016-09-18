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

        public float CostoLlamada
        {
            get
            {
                return this._costo;
            }
        }

        public void Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append("Duracion: " + this.duracion.ToString());
            str.Append(" Nro.Origen: " + this.nroOrigen.ToString());
            str.Append(" Nro.Destino: " + this.nroDestino.ToString());
            str.Append(" Costo Llamada: ")+this.CostoLlamada.ToString());

            str.ToString();
        }

        private float CalcularCosto()
        {

        }
    }
}

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

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        /// <summary>
        /// Determina si el objeto pasado es del tipo local.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {          
            return obj.GetType() == typeof(Local);
        }
        /// <summary>
        /// Haace publicos los datos de la llamada local.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine(base.Mostrar());
            str.Append(" Cargo:" + this._costo);
            str.Append(" Costo:$" + this.CostoLlamada);


            return str.ToString();
        }

        private float CalcularCosto()
        {
            return this._costo * this.duracion;
        }
    }
}

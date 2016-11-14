using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    [Serializable]
    public class Provincial:Llamada
    {
        protected eFranja _franjaHoraria;

        public Provincial()
        {

        }

        public Provincial(string origen, eFranja miFranja, float duracion, string destino)
            :base(duracion,origen,destino)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(eFranja miFranja, Llamada unaLlamada) : this(unaLlamada.nroOrigen, (eFranja)miFranja, unaLlamada.duracion, unaLlamada.nroDestino)
        { }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        /// <summary>
        /// Determina si el obj es de l mismo tipo que la instancia actual.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Provincial);
        }
        /// <summary>
        /// Hace publicos los datos de la llamada provincial.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            switch (this._franjaHoraria)
            {
                case eFranja.Franja_1:
                    return (this.duracion) * (float)0.99;
                case eFranja.Franja_2:
                    return (this.duracion) * (float)1.25;
                case eFranja.Franja_3:
                    return (this.duracion) * (float)0.66;
                default:
                    return 0;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine(base.Mostrar());
            str.Append(" Franja:" + this._franjaHoraria.ToString());
            str.Append(" Costo:$" + this.CostoLlamada);

            return str.ToString();
        }
    }
}

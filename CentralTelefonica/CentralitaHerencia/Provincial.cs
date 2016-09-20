using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        protected eFranja _franjaHoraria;


        public Provincial(string origen, eFranja miFranja, float duracion, string destino)
            :base(duracion,origen,destino)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(eFranja miFranja, Llamada unaLlamada) : this(unaLlamada.nroOrigen, (eFranja)miFranja, unaLlamada.duracion, unaLlamada.nroDestino)
        { }

        public float costoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
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

        public new string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append("Dur:" + this.duracion.ToString());
            str.Append(" Origen:" + this.nroOrigen.ToString());
            str.Append(" Destino:" + this.nroDestino.ToString());
            str.Append(" Franja:" + this._franjaHoraria.ToString());
            str.Append(" Costo:$" + this.costoLlamada);

            return str.ToString();
        }
    }
}

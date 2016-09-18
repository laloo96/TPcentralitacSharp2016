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
                return this.costoLlamada;
            }
        }

        private float CalcularCosto()
        {
            switch ((int)this._franjaHoraria)
            {
                case 1:
                    return (this.duracion) * (float)0.99;
                case 2:
                    return (this.duracion) * (float)1.25;
                case 3:
                    return (this.duracion) * (float)0.66;
                default:
                    return 0;
            }
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append("Duracion: " + this.duracion.ToString());
            str.Append(" Nro.Origen: " + this.nroOrigen.ToString());
            str.Append(" Nro.Destino: " + this.nroDestino.ToString());
            str.Append(" Costo Llamada: " + this.costoLlamada.ToString());
            str.Append(" FranjaHoraria: " + this._franjaHoraria.ToString());

            return str.ToString();
        }
    }
}

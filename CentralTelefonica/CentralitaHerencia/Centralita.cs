using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamada
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }

       /* public GananciaPorTotal()
        { }

        public GananciaPorLocal()
        { }

        public GananciaPorProvincial()
        { }*/

        /// <summary>
        /// (Privado. Recibe un Enumerado de tipoTipoLlamada y retornará el valor de lo recaudado, segúnel criterio elegido).
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(TipoLlamada tipo)
        {
            return 0;
        }
        /// <summary>
        /// Mostrará la razón social, la ganancia total,ganancia por llamados locales y provinciales y el detalle de las llamadas realizadas
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append(" RazonSocial: " + this._razonSocial);//Faltan las ganancias.

            foreach (Llamada item in this._listaDeLlamadas)
            {
                str.AppendLine(item.Mostrar());
            }

            return str.ToString();
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(CentralitaHerencia.Llamada.OrdenarPorDuracion);
        }
    }
}

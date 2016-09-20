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

        #region getters
        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }

        public float CalcularPorTotal
        {
            get
            {
                return this.CalcularGanancia(tipoLlamada.Todas);
            }
        }

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(tipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(tipoLlamada.Provincial);
            }
        }
        #endregion

        public string Mostrar()
        {
            Local loc;
            Provincial prov;
            StringBuilder str = new StringBuilder();

            str.AppendLine(" RazonSocial: " + this._razonSocial);
            str.AppendLine(" GananciaTotal: "+this.CalcularPorTotal);
            str.AppendLine(" GananciaXProvincial: " + this.GananciaPorProvincial);
            str.AppendLine(" GananciaXLocal: " + this.GananciaPorLocal);
            str.AppendLine("");
            str.AppendLine("---------------Llamadas-------------");

            foreach (var item in this._listaDeLlamadas)
            {
                if (item.GetType() == typeof(Local))
                {
                    loc = (Local)item;
                    str.AppendLine(loc.Mostrar());
                }
                if (item.GetType() == typeof(Provincial))
                {
                    prov = (Provincial)item;
                    str.AppendLine(prov.Mostrar());
                }               
            }

            return str.ToString();
        }

        private float CalcularGanancia(tipoLlamada tipo)
        {
            float ganancia=0;
            Provincial auxProvincial;
            Local auxLocal;

            switch (tipo)
            {

                case tipoLlamada.Local:
                    foreach (var item in this.Llamadas)
                    {
                        if (item.GetType() == typeof(Local))
                        {
                            auxLocal = (Local)item;
                            ganancia += auxLocal.CostoLlamada;
                        }
                    }
                    break;
                case tipoLlamada.Provincial:
                    foreach (var item in this.Llamadas)
                    {
                        if (item.GetType() == typeof(Provincial))
                        {
                            auxProvincial = (Provincial)item;
                            ganancia += auxProvincial.costoLlamada;
                        }
                    }
                    break;
                default:
                    foreach (var item in this.Llamadas)
                    {
                        if (item.GetType() == typeof(Local))
                        {
                            auxLocal = (Local)item;
                            ganancia += auxLocal.CostoLlamada;
                        }
                    }
                    foreach (var item in this.Llamadas)
                    {
                        if (item.GetType() == typeof(Provincial))
                        {
                            auxProvincial = (Provincial)item;
                            ganancia += auxProvincial.costoLlamada;
                        }
                    }
                    break;
            }               
            return ganancia;
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(CentralitaHerencia.Llamada.OrdenarPorDuracion);
        }
    }
}
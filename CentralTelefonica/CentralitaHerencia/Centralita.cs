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


        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            bool contiene = false;

            foreach (Llamada item in central.Llamadas)
            {
                if (item == nuevaLlamada)
                {
                    contiene = true;
                }
            }

            return contiene;
        }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator+(Centralita central, Llamada nuevaLlamada)
        {
            if (!(central == nuevaLlamada))
            {
                central.AgregarLlamada(nuevaLlamada);
            }
            else
                Console.WriteLine("Esta llamada se ha registrado.");

            return central;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private string Mostrar()
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
                    str.AppendLine(loc.ToString());
                }
                if (item.GetType() == typeof(Provincial))
                {
                    prov = (Provincial)item;
                    str.AppendLine(prov.ToString());
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
                            ganancia += auxProvincial.CostoLlamada;
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
                            ganancia += auxProvincial.CostoLlamada;
                        }
                    }
                    break;
            }               
            return ganancia;
        }

        private void AgregarLlamada(Llamada call)
        {
            this._listaDeLlamadas.Add(call);
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(CentralitaHerencia.Llamada.OrdenarPorDuracion);
        }
    }
}
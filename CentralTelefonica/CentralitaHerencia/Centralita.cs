using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace CentralitaHerencia
{
    [Serializable]
    [XmlInclude(typeof(Local))]
    [XmlInclude(typeof(Provincial))]
    [XmlInclude(typeof(Llamada))]
    public class Centralita:ISerializable
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        private string _ruta;

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

        public string RutaDelArchivo
        {
            get
            {
                return this._ruta;
            }

            set
            {
                this._ruta = value;
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

            try
            {
                if (!(central == nuevaLlamada))
                {
                    central.AgregarLlamada(nuevaLlamada);
                }
                else
                    throw new Exception();
            }
            catch (Exception e)
            {

                throw new CentralitaException("Error la llamada ya se ha registrado.",e.Source,e.TargetSite.ToString(),e);
            }

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
            bool escribir = true;

            try
            {
                this._listaDeLlamadas.Add(call);
                this.GuardarEnArchivo(call, escribir);
            }
            catch (Exception e)
            {

                throw new CentralitaException(e.Message, e.Source, e.TargetSite.ToString(), e);
            }
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(CentralitaHerencia.Llamada.OrdenarPorDuracion);
        }

        public bool DeSerialize()
        {
            Centralita central = null;
            bool succed = false;

            try
            {
                using (XmlTextReader lector = new XmlTextReader(RutaDelArchivo))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Centralita));
                    central = (Centralita)serializador.Deserialize(lector);
                    succed = true;
                }
            }
            catch (Exception e)
            {
                succed = false;
                throw new CentralitaException("Error al intentar desserializar el archivo.",e.Source,e.TargetSite.ToString(),e);
            }

            return succed;
        }

        public bool Serialize()
        {
            bool succed = false;

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(RutaDelArchivo, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Centralita));
                    serializador.Serialize(escritor,this);
                    succed = true;
                }
            }
            catch (Exception e)
            {
                succed = false;
                throw new CentralitaException("Error al intentar serializar",e.Source,e.TargetSite.ToString(),e);

            }

            return succed;
        }

        private bool GuardarEnArchivo(Llamada unaLlamada, bool agrego)
        {
            bool succed = false;

            try
            {
                using (StreamWriter escritor = new StreamWriter("Centrlita.txt", agrego))
                {
                    escritor.WriteLine("<----------------------------------------------------->");
                    escritor.WriteLine("CALL: ");
                    escritor.WriteLine(DateTime.Now.ToString());

                    if (unaLlamada.GetType() == typeof(Local))
                        escritor.WriteLine(((Local)unaLlamada).ToString());
                    else if (unaLlamada.GetType() == typeof(Provincial))
                        escritor.WriteLine(((Provincial)unaLlamada).ToString());
                    succed = true;
                }

            }
            catch (Exception e)
            {
                succed = false;
                throw new CentralitaException("Error al intentar escribir en archivo", e.Source, e.TargetSite.ToString(), e);
            }

            return succed;
        }
    }
}
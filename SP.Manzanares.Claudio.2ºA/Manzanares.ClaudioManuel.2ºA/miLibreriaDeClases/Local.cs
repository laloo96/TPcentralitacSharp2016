using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miLibreriaDeClases
{
    public abstract class Local
    {
        protected string legajo;
        protected string _direccion;
        protected string _anchoDeFrente;
        
        public Local(string direccion, string anchofrente,string legajo)
        {
            this._direccion = direccion;
            this._anchoDeFrente = anchofrente;
            this.legajo = legajo;
        }


        protected abstract string Legajo { get; set; }


        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("---Local---");
            str.AppendLine("Direccion: " + this._direccion);
            str.AppendLine("AnchoFrente: " + this._anchoDeFrente);
            str.AppendLine("Legajo: " + this.legajo);

            return str.ToString();
        }


    }
}

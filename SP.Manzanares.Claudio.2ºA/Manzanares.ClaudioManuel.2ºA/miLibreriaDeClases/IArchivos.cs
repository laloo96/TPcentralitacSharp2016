using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miLibreriaDeClases
{
    public interface IArchivos<T>
    {
        bool Guardar(string ruta);
        bool Leer(string ruta,out T datos);
    }
}

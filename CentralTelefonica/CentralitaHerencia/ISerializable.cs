using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public interface ISerializable
    {
        string RutaDelArchivo{ get; set; }
        bool DeSerialize();
        bool Serialize();
    }
}

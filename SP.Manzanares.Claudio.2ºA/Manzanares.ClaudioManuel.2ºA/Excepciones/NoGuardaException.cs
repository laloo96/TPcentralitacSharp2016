using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class NoGuardaException:Exception
    {
        string fuenteProblema;

        public NoGuardaException(string message)
            :base(message)
        { 
        
        }

        public NoGuardaException(string message, Exception inner)
            :base(message,inner)
        { 
        
        }

        public NoGuardaException(string message, Exception inner, string source)
            :base(message,inner)
        {
            this.fuenteProblema = source;
        }
    }
}

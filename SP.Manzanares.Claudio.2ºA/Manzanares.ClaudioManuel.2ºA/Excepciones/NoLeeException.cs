using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class NoLeeException:Exception
    {
        public NoLeeException(string message, Exception inner)
            :base(message,inner)
        { 
            
        }

        public NoLeeException(string message)
            :base(message)
        {

        }
    }
}

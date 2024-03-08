using System;

namespace Excepciones
{
    public class BlancoException : Exception
    {
        
            public BlancoException()
                : base("Campo en blanco")
            {
            }
    }
}

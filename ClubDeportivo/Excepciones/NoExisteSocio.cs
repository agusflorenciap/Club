using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class NoExisteSocio : Exception
    {

        public NoExisteSocio()
                : base("No se encontró un socio registrado con ese DNI")
        {
        }
    }
}

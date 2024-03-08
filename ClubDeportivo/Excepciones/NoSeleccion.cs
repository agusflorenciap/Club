using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class NoSeleccion : Exception
    {
        public NoSeleccion()
                : base("No seleccionó nada en la lista")
        {
        }
    }
}

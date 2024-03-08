using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    public class ActividadLlena : Exception
    {
        public ActividadLlena()
             : base("La actividad no tiene cupo")
        {
        }
    }
}

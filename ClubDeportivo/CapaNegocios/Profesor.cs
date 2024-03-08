using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace CapaNegocios
{
    [Serializable]
    public class Profesor
    {
        private protected int dni;
        private protected string nomb;
        private protected List<Actividad> actividades;

        public Profesor (int unDni, string unNomb)
        {
            dni = unDni;
            nomb = unNomb;
            actividades = new List<Actividad>();
        }

        public void agregarAct (Actividad a)
        {
            actividades.Add(a);
        }

        public override string ToString()
        {
            return dni + " - " + nomb;
        }

    }
}

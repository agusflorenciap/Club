using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.CompilerServices;


namespace CapaNegocios
{
    [Serializable]
    public abstract class Socio
    {
        protected int dni;
        protected string nomb;
        protected List<APagar> listaPagos;


        public Socio(int unDni, string unNomb)
        {
            dni = unDni;
            nomb = unNomb;
            listaPagos = new List<APagar>();
        }

        public override string ToString()
        {
            return dni + " - " + nomb;
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nomb; }
            set { nomb = value; }
        }


        public abstract ArrayList pasarseARelacional();

        public abstract string decimeTipo();

        public abstract List<Actividad> dameActSinCargo();

        public abstract List<Actividad> dameActExcedentes();
        public abstract List<Actividad> dameActividades();
        public abstract void agregateActividad(Actividad a);
    }
}

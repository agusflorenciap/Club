using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace CapaNegocios
{
    [Serializable]
    public class SocioAct : Socio
    {
        private List<Actividad> actividades;


        public SocioAct(int unDni, string unNomb)
                : base(unDni, unNomb)
        {
            actividades = new List<Actividad>();
        }


        public override String decimeTipo()
        {
            return ("Actividades");
        }

        public override List<Actividad> dameActividades()
        {
            return (actividades);
        }

        public override List<Actividad> dameActSinCargo()
        {
            return (null);
        }

        public override List<Actividad> dameActExcedentes()
        {
            return (null);
        }

        public override void agregateActividad(Actividad a)
        {
            actividades.Add(a);

        }

        public override ArrayList pasarseARelacional()
        {
            ArrayList datos = new ArrayList();
            datos.Add(base.dni);
            datos.Add(base.nomb);
            datos.Add(this.decimeTipo());
            datos.Add(1);

            return (datos);
        }

    }
}


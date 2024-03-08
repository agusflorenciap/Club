using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace CapaNegocios
{
    [Serializable]

    public class SocioClub : Socio
    {
        private List<Actividad> actSinCargo;
        private List<Actividad> actExcedentes;
        private int cuotaSocial;


        public SocioClub(int unDni, string unNomb, int cuo)
               : base(unDni, unNomb)
        {
            actSinCargo = new List<Actividad>();
            actExcedentes = new List<Actividad>();
            cuotaSocial = cuo;
        }

        public override String decimeTipo()
        {
            return ("Club");
        }

        public override List<Actividad> dameActSinCargo()
        {
            return (actSinCargo);
        }

        public override List<Actividad> dameActExcedentes()
        {
            return (actExcedentes);
        }

        public override List<Actividad> dameActividades()
        {
            return (null);
        }

        public bool sinCargo()
        {
            return (actSinCargo.Count < 5);
        }

        public override void agregateActividad(Actividad a)
        {
            if (this.sinCargo())
                actSinCargo.Add(a);
            else
                actExcedentes.Add(a);

        }


        public override ArrayList pasarseARelacional()
        {
            ArrayList datos = new ArrayList();
            datos.Add(base.dni);
            datos.Add(base.nomb);
            datos.Add(this.decimeTipo());
            datos.Add(cuotaSocial);

            return (datos);
        }



    }
}

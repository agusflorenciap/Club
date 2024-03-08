using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace CapaNegocios
{
    [Serializable]
    public class Actividad
    {

        private int cod;
        private string nomb;
        private int horaI; //era int
        private int horaF; //era int
        private string dia;
        private Profesor profe;
        private int cantMaxPart;
        private List<Socio> inscriptos;
        private int costo;

        
        public Actividad (int c, string n, int horI, int horF, string d, Profesor p, int cantMax, int cost)
        {
            cod = c;
            nomb = n;
            horaI = horI;
            horaF = horF;
            profe = p;
            dia = d;
            cantMaxPart = cantMax;
            inscriptos = new List<Socio>();
            costo = cost;
        }

        public ArrayList pasarseARelacional()
        {
            ArrayList datos = new ArrayList();
            datos.Add(cod);
            datos.Add(nomb);
            datos.Add(horaI);
            datos.Add(horaF);
            datos.Add(dia);
            //datos.Add(profe);
            datos.Add(cantMaxPart);
            //datos.Add(inscriptos);
            datos.Add(costo);

            return (datos);
        }

        public int Cod
        {
            get { return cod; }
        }

        public override string ToString()
        {
            return (cod + " - " + nomb + " - INSCRIPTOS: " + inscriptos.Count);
        }


        public bool cursoLleno ()
        {
            return (inscriptos.Count >= cantMaxPart);
        }

        public void sumateSocio (Socio s)
        {
            inscriptos.Add(s);
        }
    }
}

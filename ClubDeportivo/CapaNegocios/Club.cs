using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class Club
    {

        private string nomb;
        private List<Socio> socios;
        private List<Profesor> profes;
        private List<Actividad> activs;

        public Club (string n)
        {
            nomb= n;
            socios = new List<Socio>();
            profes = new List<Profesor>();
            activs = new List<Actividad>();
            this.recuperarSocios();
            //this.recuperarProfesores();
            this.recuperarActividades();
            this.recuperarTablaSocioAct();
        }


        public string Nomb
        {
            get { return nomb; }
        }

        public List<Socio> ListaSocios
        {
            get { return socios; }
        }

        public List<Profesor> ListaProfes
        {
            get { return profes; }
        }

        public List<Actividad> ListaActivs
        {
            get { return activs; }
        }

        public static void PonerPathABaseAccess(string l)
        {
            Datos.PonerPathBaseAccess(l);
        }

        public void agregarSocio(Socio s)
        {
            bool todoBien = false;
            if (s != null)
            {

                todoBien = Datos.GuardarSocio(s.pasarseARelacional());
                if (todoBien)
                    this.socios.Add(s);
            }

        }
        public void recuperarSocios()
        {
            Socio s = null;
            int dni;
            string nombre;
            string tipoSocio;
            int cuotaSocial;

            List <ArrayList> contenedorSocios = new List<ArrayList>();
            contenedorSocios = Datos.RecuperarSocios(); //en vez de tener un array de datos de socios, hacer una list de arraylist. cada posición del list es un array (con datos de un socio)
                                                        //con cada posición creo un socio.

            ArrayList posicionActual; 

            for (int i = 0; i <contenedorSocios.Count; i++)
            {
                posicionActual= new ArrayList();
                posicionActual = contenedorSocios[i];

                dni = int.Parse(posicionActual[0].ToString());
                nombre = posicionActual[1].ToString(); //en teoría ya es tipo string pero x las dudas lo paso también
                tipoSocio = posicionActual[2].ToString();
                cuotaSocial = int.Parse(posicionActual[3].ToString());

                if (tipoSocio == "Club")
                    s = new SocioClub(dni, nombre, cuotaSocial);

                s = new SocioAct(dni, nombre);

                socios.Add(s);

            }

        }

        public void agregarActividad (Actividad a)// Pone en la lista y Guarda en la Base de Datos. no hecho/modificado todavía
        {
            bool todoBien = false;
            if (a != null)
            {

                todoBien = Datos.GuardarActiv(a.pasarseARelacional());
                if (todoBien)
                    this.activs.Add(a);
            }
        }

        public void recuperarActividades()
        {
            Actividad a = null;
            int cod;
            string nomb;
            int horaI;
            int horaF;
            string dia;
            int cantMaxPart;
            int costo;

            List<ArrayList> contenedorActividades = new List<ArrayList>();
            contenedorActividades = Datos.RecuperarActividades(); 

            ArrayList posicionActual;

            for (int i = 0; i < contenedorActividades.Count; i++)
            {
                posicionActual = new ArrayList();
                posicionActual = contenedorActividades[i];

                cod = int.Parse(posicionActual[0].ToString());
                nomb = posicionActual[1].ToString(); ;
                horaI = int.Parse(posicionActual[2].ToString());
                horaF = int.Parse(posicionActual[3].ToString());
                dia = posicionActual[4].ToString();
                cantMaxPart = int.Parse(posicionActual[5].ToString());
                costo = int.Parse(posicionActual[6].ToString());

                Profesor p = null; //despues lo voy a llenar con la tabla de relacion pero x ahora no
                a = new Actividad(cod,nomb,horaI,horaF,dia,p,cantMaxPart,costo);

                activs.Add(a);

            }

        }


        public void GuardarEnTablaSocioAct(int dni, int codAct)
        {

            // tengo que crear un array con esos dos campos y se lo paso a la capa de datos
            //ahí es donde un método guardarInscrip va a hacer lo mismo que los que ya hice ((hacer el insert y blabla))

            ArrayList datos = new ArrayList();
            datos.Add(dni);
            datos.Add(codAct);
            Datos.GuardarInscripcion(datos);


           


        }

        public void recuperarTablaSocioAct ()
        {
            int dni;
            int codActiv;

            List<ArrayList> contenedorInscripciones = new List<ArrayList>();
            contenedorInscripciones = Datos.RecuperarInscripcion();

            ArrayList posicionActual;

            for (int i = 0; i < contenedorInscripciones.Count; i++)
            {
                posicionActual = new ArrayList();
                posicionActual = contenedorInscripciones[i];

                dni = int.Parse(posicionActual[0].ToString());
                codActiv = int.Parse(posicionActual[1].ToString());


                Socio s = buscameSocio(dni);
                Actividad a = buscameActividad(codActiv);
               
                if ((s!=null) && (a!=null))
                {
                    s.agregateActividad(a);
                    a.sumateSocio(s);
                }
            }
        }





        public void eliminarActividad(Actividad a)
        {
            activs.Remove(a);
        }


        public void agregarProf(Profesor p) 
        {
            profes.Add(p);
        }

        public void eliminarProf(Profesor p)
        {
            profes.Remove(p);
        }


        

        public void eliminarSocio(Socio s)
        {
            socios.Remove(s);
        }

        public Socio buscameSocio (int dni)
        {
            int i = 0;
            Socio s;
      
            while ((i < socios.Count) && (dni != socios.ElementAt(i).Dni))
                i++;

            if (i == socios.Count) //no existe el socio
                s = null;
            else
                s = socios.ElementAt(i);

            return (s);
        }

        public Actividad buscameActividad(int codActiv)
        {
            int i = 0;
            Actividad a;

            while ((i < activs.Count) && (codActiv != activs.ElementAt(i).Cod))
                i++;

            if (i == activs.Count) //no existe la activ
                a = null;
            else
                a = activs.ElementAt(i);

            return (a);
        }




    }
}

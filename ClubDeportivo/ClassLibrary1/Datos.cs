using System;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;

namespace CapaDatos
{
    public class Datos
    {
        private static string LugarBaseClub;


        private static string Str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        //"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\Persistencia\baseClub.mdb";
        private static OleDbConnection Con;
        private static OleDbCommand Cmd;
        private static OleDbDataAdapter Da;

        private static DataSet Ds;


        public static void PonerPathBaseAccess(string l)
        {
            //LugarBaseClub = l+@"\Persistencia\baseClub.mdb";
            LugarBaseClub = l;
            Datos.Str += LugarBaseClub;

        }


        public static bool GuardarSocio(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 4)
            {
                try
                {
                    int dni = int.Parse(datos[0].ToString());
                    string nombre = datos[1].ToString();
                    string tipoSocio = datos[2].ToString();
                    int cuotaSocial = int.Parse(datos[3].ToString());


                    string strCmd = "INSERT INTO Socio (dni,nomb,tipoSocio,cuotaSocial) VALUES (" + dni + "," + "'" + nombre + "'" + "," + "'" + tipoSocio + "'" + "," + cuotaSocial + ")";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return (todoBien);

        }

        public static List<ArrayList> RecuperarSocios()
        {

            ArrayList datosSocio;
            List <ArrayList> contenedorSocios  = new List <ArrayList>();

            try
            {

                string strCmd = "SELECT * FROM Socio ORDER BY dni";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i=0; i<(Ds.Tables[0].Rows.Count);i++) //hago la list de arraylist VER DATASET ERROR: "FUERA DE RANGO"
                {
                    datosSocio = new ArrayList();

                    datosSocio.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString()); //dni        
                    datosSocio.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString()); //nomb       
                    datosSocio.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString()); //tipoSocio
                    datosSocio.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString()); //cuotaSocial
                    contenedorSocios.Add(datosSocio);
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return (contenedorSocios);
        }

        public static bool GuardarActiv(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 7)
            {
                try
                {
                    int cod = int.Parse(datos[0].ToString());
                    string nombre = datos[1].ToString();
                    int horaI = int.Parse(datos[2].ToString()); 
                    int horaF = int.Parse(datos[3].ToString());
                    string dia = datos[4].ToString();
                    int cantMaxPart = int.Parse(datos[5].ToString());
                    int costo = int.Parse(datos[6].ToString());




                    string strCmd = "INSERT INTO Actividad (cod,nombre,horaI,horaF,dia,cantMaxPart,costo) VALUES (" + cod + "," + "'" + nombre + "'" + "," + horaI + "," + horaF + ","+"'"+ dia +"'" +"," + cantMaxPart + "," + costo + ")";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return (todoBien);

        }

        public static List<ArrayList> RecuperarActividades()
        {

            ArrayList datosActiv;
            List<ArrayList> contenedorActividades = new List<ArrayList>();

            try
            {

                string strCmd = "SELECT * FROM Actividad ORDER BY cod";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < (Ds.Tables[0].Rows.Count); i++) //hago la list de arraylist VER DATASET ERROR: "FUERA DE RANGO"
                {
                    datosActiv = new ArrayList();

                    datosActiv.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString()); //cod        
                    datosActiv.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString()); //nomb       
                    datosActiv.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString()); //horaI
                    datosActiv.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString()); //horaF
                    datosActiv.Add(Ds.Tables[0].Rows[i].ItemArray[4].ToString()); //dia       
                    datosActiv.Add(Ds.Tables[0].Rows[i].ItemArray[5].ToString()); //cantMaxPart
                    datosActiv.Add(Ds.Tables[0].Rows[i].ItemArray[6].ToString()); //costo
                    contenedorActividades.Add(datosActiv);
                }

                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return (contenedorActividades);
        }


        public static void GuardarInscripcion (ArrayList datos)
        {
            if (datos != null && datos.Count == 2)
            {
                try
                {
                    int dni = int.Parse(datos[0].ToString());
                    int codActiv = int.Parse(datos[1].ToString());

                    string strCmd = "INSERT INTO SocioActiv (dni,cod) VALUES (" + dni + "," + codActiv + ")";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }

        }

        public static List<ArrayList> RecuperarInscripcion()
        {

            ArrayList datosInscrip;
            List<ArrayList> contenedorInscripciones = new List<ArrayList>();

            try
            {

                string strCmd = "SELECT * FROM SocioActiv ORDER BY dni";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < (Ds.Tables[0].Rows.Count); i++) //hago la list de arraylist VER DATASET ERROR: "FUERA DE RANGO"
                {
                    datosInscrip = new ArrayList();

                    datosInscrip.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString()); //dni        
                    datosInscrip.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString()); //codActiv       
                    contenedorInscripciones.Add(datosInscrip);
                }
                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return (contenedorInscripciones);
        }


    }
}

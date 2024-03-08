using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excepciones;
using CapaNegocios;

namespace WindowsFormsApp1
{
    public partial class FInscripcion : Form
    {

        Club c;
        Socio s;
        Actividad seleccionada;
        public FInscripcion(Club club)
        {
            c = club;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //buscar socio x dni
        {
            try
            {
                int dni = int.Parse(maskedTextBoxDni.Text);
                s = c.buscameSocio(dni);

                if (s == null)
                    throw new NoExisteSocio();

                else //existe. muestro el resto del formulario.
                {
                   
                    label5.Visible = true;
                    Nombre.Visible = true;
                    Nombre.Text = s.Nombre;
                    TipoS.Text = s.decimeTipo();
                    label7.Visible = true;

                    listBoxActividadesInscripcion.Visible = true;
                    listBoxActividadesInscripcion.DataSource = null;
                    listBoxActividadesInscripcion.DataSource = c.ListaActivs;
                    listBoxActividadesInscripcion.ClearSelected();


                    if (s.decimeTipo()=="Club") //muestro todo lo relacionado al socio club
                    {
                        label3.Visible = true;
                        label4.Visible = true;
                        listBoxActSinCargo.Visible = true;
                        listBoxActSinCargo.DataSource = null;
                        listBoxActSinCargo.DataSource = s.dameActSinCargo();
                        listBoxActSinCargo.ClearSelected();

                        listBoxActExcedentes.Visible = true;
                        listBoxActExcedentes.Visible = true;
                        listBoxActExcedentes.DataSource = null;
                        listBoxActExcedentes.DataSource = s.dameActExcedentes();
                        listBoxActExcedentes.ClearSelected();
                    }

                    else //es el otro socio que tiene actividades nomas
                    {
                        label6.Visible = true;
                        listBoxActividadesSocio.Visible = true;
                        listBoxActividadesSocio.Visible = true;
                        listBoxActividadesSocio.DataSource = null;
                        listBoxActividadesSocio.DataSource = s.dameActividades();
                        listBoxActividadesSocio.ClearSelected();
                    }
                }

            }

            catch (BlancoException ex)
            {
                MessageBox.Show(ex.Message);
                maskedTextBoxDni.Focus();
            }

            catch (NoExisteSocio ex)
            {
                MessageBox.Show(ex.Message);
                maskedTextBoxDni.Focus();

            }

        }

        private void button2_Click(object sender, EventArgs e) //aceptar
        {

            try
            {
                seleccionada = (Actividad)listBoxActividadesInscripcion.SelectedItem;
                if (seleccionada.cursoLleno()) //si no hay cupo
                    throw new ActividadLlena();

                s.agregateActividad(seleccionada); 
                seleccionada.sumateSocio(s);
                //aca tendría que hacer la tabla de relación activ-socio:
                c.GuardarEnTablaSocioAct(s.Dni, seleccionada.Cod);
            }

            catch (ActividadLlena ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            s = null;
            seleccionada = null;
            this.Close();
        }
    }
}

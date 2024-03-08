using CapaNegocios;
using Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FAltaActiv : Form
    {
        private Actividad activ;
        private List<Profesor> listP;

        public FAltaActiv(List <Profesor> listaProfes)
        {
            listP = listaProfes;
            InitializeComponent();
            listBoxProfes.DataSource = null;
            listBoxProfes.DataSource = listP; //no sé que hice pero me empecé a pasar la lista de formulario a formulario para poder mostrarla acá
            listBoxProfes.ClearSelected();

        }

        public Actividad Activ
        {
            get { return activ; }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

            try
            {
                int c = int.Parse(textBoxCod.Text);
                string nomb = textBoxNomb.Text;
                if (nomb.Length == 0)
                    throw new BlancoException();

                Profesor p = (Profesor)listBoxProfes.SelectedItem;
                if (p ==null)
                    throw new NoSeleccion();

                //int horaI = int.Parse(maskedTextBoxHoraI.Text);
                //int horaF = int.Parse(maskedTextBoxHoraF.Text);


                int horaI =int.Parse(maskedTextBoxHoraI.Text);
                int horaF= int.Parse(maskedTextBoxHoraF.Text);

                string dia = (String) comboBoxDia.SelectedItem; //desplegable
                int cant = int.Parse(textBoxParticipantes.Text);
                int costo = int.Parse(textBoxCosto.Text);
                activ = new Actividad(c, nomb, horaI, horaF, dia, p, cant, costo);
                p.agregarAct(activ); //faltaba agregarle actividad al profesor
                this.Close();
            }

            catch (BlancoException ex)
            {
                MessageBox.Show(ex.Message);
                textBoxNomb.Focus();
            }

            catch (NoSeleccion ex)
            {
                MessageBox.Show(ex.Message);
                listBoxProfes.Focus();
            }
       
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        

        private void Cancelar_Click(object sender, EventArgs e)
        {
            activ = null;
            this.Close();

        }
        
    }
}

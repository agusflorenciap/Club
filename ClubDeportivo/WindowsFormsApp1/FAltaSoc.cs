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
    public partial class FAltaSoc : Form
    {

        private Socio soc;
        string tipoSoc;
        public FAltaSoc()
        {
            
            InitializeComponent();


        }

        public Socio So
        {
            get { return soc; }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = int.Parse(maskedTextBoxDNI.Text);
                string nomb = textBoxNomb.Text;
                if (nomb.Length == 0)
                    throw new BlancoException();


                
                if (tipoSoc == null)
                    throw new NoSeleccion();

                if (tipoSoc== "Club")
                {
                    int cuota = int.Parse(textBoxCuotaSocioClub.Text);
                    soc = new SocioClub(dni, nomb, cuota);
                }

                soc = new SocioAct(dni, nomb);

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
                comboBoxTipoSocio.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


      

        private void comboBoxTipoSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoSoc = (String)comboBoxTipoSocio.SelectedItem;
            if (tipoSoc == "Club")
            {
                label4.Visible = true;
                textBoxCuotaSocioClub.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBoxCuotaSocioClub.Visible = false;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            soc = null;
            this.Close();
        }
    }
}

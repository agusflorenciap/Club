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
    public partial class FAltaProf : Form
    {
        private Profesor p;
        public FAltaProf()
        {
            InitializeComponent();
        }

        public Profesor Prof
        {
            get { return p; }
        }
     

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = int.Parse(maskedTextBoxDNI.Text);
                string nomb = textBoxNombre.Text;
                if (nomb.Length == 0)
                    throw new BlancoException();
                p = new Profesor(dni, nomb);
                this.Close();
            }

            catch (BlancoException ex)
            {
                MessageBox.Show(ex.Message);
                textBoxNombre.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            p = null;
            this.Close();
        }
    }
}

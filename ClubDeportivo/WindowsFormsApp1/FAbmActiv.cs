using CapaNegocios;
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
    public partial class FAbmActiv : Form
    {
        private Actividad a;
        private Club c;
    
        public FAbmActiv(Club clu)
        {
            c = clu;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //alta activ
        {
            FAltaActiv fAlta = new FAltaActiv(c.ListaProfes);

            fAlta.ShowDialog();
            a = fAlta.Activ;
            c.agregarActividad(a);

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = null;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FListadoActivs fList = new FListadoActivs(c.ListaActivs);
            fList.ShowDialog();
            

        }
    }
}

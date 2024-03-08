using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace WindowsFormsApp1
{
    public partial class FAbmProf : Form
    {
        private Club c;
        private Profesor p;
        public FAbmProf(Club Club)
        {
            c = Club;
            InitializeComponent();
        }


        public Club Club
        {
            get { return c; }
        }

        private void button1_Click_1(object sender, EventArgs e) //alta profe
        {
            FAltaProf fAlta = new FAltaProf();

            fAlta.ShowDialog();
            p = fAlta.Prof;
            c.agregarProf(p);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p = null;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FListadoProfes fList = new FListadoProfes(c.ListaProfes);
            fList.ShowDialog();
        }
    }
}

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
    public partial class FAbmSoc : Form
    {
        private Club c;
        private Socio s;
        public FAbmSoc(Club club )
        {
            c = club;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) //alta socio
        {
            FAltaSoc fAltaSoc = new FAltaSoc();

            fAltaSoc.ShowDialog();
            s = fAltaSoc.So;
            c.agregarSocio(s);

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FListadoSocs fList = new FListadoSocs(c.ListaSocios);
            fList.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s = null;
            this.Close();
        }
    }
}

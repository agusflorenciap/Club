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
    public partial class FListadoSocs : Form
    {
        public FListadoSocs(List <Socio> lista)
        {
            
            InitializeComponent();
            listBoxSocs.DataSource = null;
            listBoxSocs.DataSource = lista;
            listBoxSocs.ClearSelected();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

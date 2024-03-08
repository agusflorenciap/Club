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
    public partial class FListadoActivs : Form
    {
        public FListadoActivs(List <Actividad> lista)
        {
            
            InitializeComponent();
            listBoxActivs.DataSource = null;
            listBoxActivs.DataSource = lista;
            listBoxActivs.ClearSelected();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FListadoProfes : Form
    {
        public FListadoProfes(List <Profesor> lista)
        {
            
            InitializeComponent();
            listBoxProfes.DataSource = null;
            listBoxProfes.DataSource = lista;
            listBoxProfes.ClearSelected();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FGestionInscrip : Form
    {

        private Club c;

        public FGestionInscrip(Club club)
        {
            c = club;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //inscripción a actividad
        {
            FInscripcion fInsc = new FInscripcion (c); //antes le pasaba la lista de socios y de actividades. ahora todo el club xq es más fácil
            fInsc.ShowDialog();
         
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

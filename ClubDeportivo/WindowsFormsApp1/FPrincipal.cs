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
    public partial class FPrincipal : Form
    {
        private Club club;
        string lugarBase; //para usar Access 
        public FPrincipal()
        {
            InitializeComponent();
            lugarBase = Application.StartupPath;
            Club.PonerPathABaseAccess(lugarBase);
            club = new Club("Club Abus");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FAbmActiv fAbmA = new FAbmActiv(club);
            fAbmA.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FAbmProf fAbmP = new FAbmProf(club);

            fAbmP.ShowDialog();
            
        }

       private void buttonSalir_Click(object sender, EventArgs e) 
        {
            this.Close();
        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            FAbmSoc fAbmS = new FAbmSoc(club);
            fAbmS.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) //inscripción/desinscripción de socio a actividad
        {
            FGestionInscrip fGesInsc = new FGestionInscrip(club);
            fGesInsc.ShowDialog();

        }
    }
}

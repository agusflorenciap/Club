using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;

namespace Web
{
    public partial class _Default : Page
    {
        private Club club;
        private string lugarBase;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                lugarBase = Server.MapPath(@"baseClub.mdb");
                Club.PonerPathABaseAccess(lugarBase);
                club = new Club("Club Abus");
                Session["Club"] = club;
                this.Title = "Club " + club.Nomb;
                ListBoxActivs.DataSource = club.ListaActivs;
                ListBoxActivs.DataBind();
                ListBoxActivs.DataSource = ((Club)Session["Club"]).ListaActivs;
                ListBoxActivs.DataBind();
            }
        }

        public void recuperarClub ()
        {
            club = (Club)Session["Club"];
        }


    }
}
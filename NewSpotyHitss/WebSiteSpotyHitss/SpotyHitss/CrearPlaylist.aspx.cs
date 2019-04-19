using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteSpotyHitss.SpotyHitss
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void crearPlaylist_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service1 = new ServiceReference1.Service1Client();
            service1.crear_playlist(this.nombrePlaylist.ToString(), this.descripcionPlaylist.ToString());
        }
    }
}
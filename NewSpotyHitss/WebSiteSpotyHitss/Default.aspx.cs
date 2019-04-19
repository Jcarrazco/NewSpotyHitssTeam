using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteSpotyHitss.SpotyHitss;

namespace WebSiteSpotyHitss
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnArtist_Click(object sender, EventArgs e)
        {
            Response.Redirect("SongByArtist.aspx");
        }
    }
}
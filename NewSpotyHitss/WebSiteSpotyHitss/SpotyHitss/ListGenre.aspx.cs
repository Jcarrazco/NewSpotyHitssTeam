using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteSpotyHitss.SpotyHitss
{
    public partial class ListGenre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGenre_Click(object sender, EventArgs e)
        {
            SpotyHitssProxy.Service1Client Client = new SpotyHitssProxy.Service1Client();
            if (TxbGenre.Text != null)
            {
                GridView1.DataSource = Client.GetSearchGenListSong(TxbGenre.Text);
                GridView1.DataBind();
            }
        }
    }
}
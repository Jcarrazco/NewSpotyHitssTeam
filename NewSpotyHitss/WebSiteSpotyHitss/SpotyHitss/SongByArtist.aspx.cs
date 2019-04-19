using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteSpotyHitss.SpotyHitss
{
    public partial class SongByArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Search_Click(object sender, EventArgs e)
        {
            var client = new SpotyHitssProxy.Service1Client();

            try
            {
                var result = client.GetListSongContract(ArtistName.Text);
                if (result != null)
                {
                    SongsGrid.DataSource = result.ToList();
                    SongsGrid.DataBind();
                }
                else
                    SongsGrid.DataSource = "not found";
            }
            catch (Exception)
            {

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteSpotyHitss.SpotyHitss
{
    public partial class InsertAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            SpotyHitssProxy.Service1Client _album = new SpotyHitssProxy.Service1Client();
            string result = _album.AddAlbum(int.Parse(this.AlbumYearTextBox.Text), this.AlbumNameTextBox.Text);
        }
    }
}
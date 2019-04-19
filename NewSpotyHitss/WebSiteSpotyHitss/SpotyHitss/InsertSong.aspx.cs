using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSiteSpotyHitss.SpotyHitssProxy;

namespace WebSiteSpotyHitss.SpotyHitss
{
    public partial class InsertSong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertSong_Click(object sender, EventArgs e)
        {
            var client = new Service1Client();
            var song = new Song() {
                ArtistName = this.txtArtistName.Text,
                Name = this.txtSongName.Text,
                Year = int.Parse(this.txtReleaseYear.Text),
                DataSong = this.FileUpload1.FileBytes
            };
            OperationResultOfint result =  client.InsertSong(song);
            Session["OpResult"] = result;
            Response.Write("<script>alert('" + result.OpMesssage + "');</script>");
        }
    }
}
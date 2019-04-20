using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSiteSpotyHitss.SpotyHitss
{
    public partial class AddPlaylistSong : System.Web.UI.Page
    {
        string connectionString = "server=CESAR\\SQLEXPRESS; DataBase=Spotify; integrated security = true";
        protected void Page_Load(object sender, EventArgs e)
        {
            GetSongs();
        }
        public void Click(object sender, EventArgs e)
        {

        }
        public void GetSongs()
        {
            string Query = "SELECT * FROM Song";
            using (SqlConnection _sqlConn = new SqlConnection(connectionString))
            {
                _sqlConn.Open();
                using (SqlCommand _sqlCommand = new SqlCommand(Query, _sqlConn))
                {
                    this.View.DataSource = _sqlCommand.ExecuteReader();
                    this.View.DataBind();
                    _sqlConn.Close();
                }
            }
        }

    }
}
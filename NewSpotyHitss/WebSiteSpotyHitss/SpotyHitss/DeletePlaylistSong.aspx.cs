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
    public partial class DeletePlaylistSong : System.Web.UI.Page
    {
        string connectionString = "server=CESAR\\SQLEXPRESS; DataBase=Spotify; integrated security = true";
        protected void Page_Load(object sender, EventArgs e)
        {
            GetSongsAndPlaylist();
            lblValidacion1.Text = "";
            lblValidacion2.Text = "";
        }
        public void Click(object sender, EventArgs e)
        {
            int temporal,temporal2;
            if (int.TryParse(txtPlaylist.Text, out temporal))
            {
                if (int.TryParse(txtSong.Text, out temporal2))
                {
                    if (Validaciones.ValidateIfSongAreIntoPlaylist(temporal, temporal2, connectionString) == true)
                    {
                        string Query = "SP_DeletePlaylist";
                        using (SqlConnection _sqlConn = new SqlConnection(connectionString))
                        {
                            _sqlConn.Open();
                            using (SqlCommand _sqlCommand = new SqlCommand(Query, _sqlConn))
                            {
                                _sqlCommand.CommandType = CommandType.StoredProcedure;
                                _sqlCommand.Parameters.Add("ID_playlist", SqlDbType.Int);
                                _sqlCommand.Parameters.Add("ID_Song", SqlDbType.Int);


                                _sqlCommand.Parameters["ID_playlist"].Value = int.Parse(txtPlaylist.Text);
                                _sqlCommand.Parameters["ID_Song"].Value = int.Parse(txtSong.Text);
                                _sqlCommand.ExecuteNonQuery();

                                _sqlConn.Close();
                            }
                        }
                        Response.Redirect("DeletePlaylistSong.aspx");
                    }
                    else
                    {
                        lblValidacion1.Text = "Song Don't Exist ON Playlist";
                    }
                }
                else
                {
                    lblValidacion1.Text = "ID Song Would be INT";
                }
            }
            else
            {
                lblValidacion2.Text = "ID Playlist Would be INT";
            }

        }
        public void GetSongsAndPlaylist()
        {
            string Query = "SELECT PS.ID,US.ID AS 'ID SONG',US.NAME AS 'NAME SONG',US.ReleaseYear AS 'RELEASE YEAR', " +
                "PL.ID AS 'ID PLAYLIST',PL.Description AS 'DESCRIPTION PLAYLIST',PL.CreateDate AS 'CREATE DATE'" +
                "FROM PlaylistSong PS INNER JOIN Song US on PS.ID_Song = US.ID INNER JOIN Playlist PL  on PS.ID_Playlist = PL.ID";
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
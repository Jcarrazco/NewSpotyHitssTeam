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
            GetSongsAndPlaylist();
            lblValidacion1.Text = "";
            lblValidacion2.Text = "";

        }
        public void Click(object sender, EventArgs e)
        {
            var _obj = Validaciones.ValidateIfSongExist(txtSong.Text, connectionString);
            if (_obj._result == true)
            {
                var _obj2 = Validaciones.ValidateIfPlaylistExist(txtPlaylist.Text, connectionString);
                if (_obj._result == true)
                {
                    if (Validaciones.ValidateIfSongAreIntoPlaylist(_obj2._ID, _obj._ID, connectionString) == false)
                    {
                        string Query = "SP_AddPlaylist";
                        using (SqlConnection _sqlConn = new SqlConnection(connectionString))
                        {
                            _sqlConn.Open();
                            using (SqlCommand _sqlCommand = new SqlCommand(Query, _sqlConn))
                            {
                                _sqlCommand.CommandType = CommandType.StoredProcedure;
                                _sqlCommand.Parameters.Add("ID_playlist", SqlDbType.Int);
                                _sqlCommand.Parameters.Add("ID_User", SqlDbType.Int);


                                _sqlCommand.Parameters["ID_playlist"].Value = int.Parse(txtPlaylist.Text);
                                _sqlCommand.Parameters["ID_User"].Value = int.Parse(txtSong.Text);
                                _sqlCommand.ExecuteNonQuery();

                                _sqlConn.Close();
                            }
                        }
                        Response.Redirect("AddPlaylistSong.aspx");
                    }
                    else
                    {
                       lblValidacion1.Text = "Song Exist ON Playlist";
                    }
                }
                else
                {
                    lblValidacion2.Text = "Playlist NOT Found";
                }
            }
            else
            {
                lblValidacion1.Text = "Song NOT Found";
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
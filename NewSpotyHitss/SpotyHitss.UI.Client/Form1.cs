using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotyHitss.UI.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertSong_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchByArtist_Click(object sender, EventArgs e)
        {
            SpotyHitssProxy.Service1Client songArtistClient = new SpotyHitssProxy.Service1Client();

            try
            {
                SpotyHitssProxy.SongArtist[] lstSong = 
                    songArtistClient.GetListSongContract(txtArtistSearch.Text);
                if (lstSong != null)
                    dataSearchByArtist.DataSource = lstSong.ToList();
                else
                    dataSearchByArtist.DataSource = "Not found";
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInsertAlbum_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchGenre_Click(object sender, EventArgs e)
        {

        }
    }
}

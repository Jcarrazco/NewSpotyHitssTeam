using SpotyHitss.Data.Objects;
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
            SpotyHitssProxy.Service1Client service = new SpotyHitssProxy.Service1Client();            
            OperationResult<int> result = service.InsertSong(this.txtNameSong.Text, this.txtArtistName.Text, int.Parse(this.txtReleaseYSong.Text));
        }

        private void btnSearchByArtist_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertAlbum_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchGenre_Click(object sender, EventArgs e)
        {

        }
    }
}

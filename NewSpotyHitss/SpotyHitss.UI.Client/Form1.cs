using SpotyHitss.Data.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Song song = new Song()
            {
                Name = this.txtNameSong.Text,
                ArtistName = this.txtArtistName.Text,
                Year = int.Parse(this.txtReleaseYSong.Text),
                DataSong = LoadSong(this.textBox4.Text)
            };
            OperationResult<int> result = service.InsertSong(song);
            MessageBox.Show(result.OpMesssage);
        }

        private void btnSearchByArtist_Click(object sender, EventArgs e)
        {
            SpotyHitssProxy.Service1Client songArtistClient = new SpotyHitssProxy.Service1Client();

            try
            {
                SongArtist[] lstSong =
                    songArtistClient.GetListSongContract(txtArtistSearch.Text);
                if (lstSong != null)
                    dataSearchByArtist.DataSource = lstSong.ToList();
                else
                    dataSearchByArtist.DataSource = "Not found";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInsertAlbum_Click(object sender, EventArgs e)
        {
            SpotyHitssProxy.Service1Client _album = new SpotyHitssProxy.Service1Client();
            string result = _album.AddAlbum(int.Parse(this.txtReleaseAlbum.Text),this.txtNameAlbum.Text);
            MessageBox.Show(result);
        }

        private void btnSearchGenre_Click(object sender, EventArgs e)
        {
            BindingList<Song> _opResult = new BindingList<Song>();
            SpotyHitssProxy.Service1Client service = new SpotyHitssProxy.Service1Client();
            foreach (Song s in service.GetSearchGenListSong(txtGenreSearch.Text))
            {
                _opResult.Add(s);
            }
            dataSearchByGenre.DataSource = _opResult;
        }

        private void btnSearchSong_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog _ofd = new OpenFileDialog()
                {
                    AddExtension = true,
                    Filter = "*.mp3|*.mp3",
                    CheckFileExists = true,
                    CheckPathExists = true
                }
            )
            {
                if(DialogResult.OK == _ofd.ShowDialog(this))
                {
                    this.textBox4.Text = _ofd.FileName;
                }
            }
        }

        private byte[] LoadSong(string path)
        {
            byte[] buffer = null;
            using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using(BinaryReader br = new BinaryReader(fs))
                {
                    long numBytes = new FileInfo(path).Length;
                    buffer = br.ReadBytes((int)numBytes);
                }
            }
            return buffer ?? new byte[1];
        }
    }
}
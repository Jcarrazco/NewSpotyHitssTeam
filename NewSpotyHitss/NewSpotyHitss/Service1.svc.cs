using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using SpotyHitss.Data.Manager;
using SpotyHitss.Data.Objects;

namespace NewSpotyHitss
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements
        (RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class Service1 : IService1
    {
        public string AddAlbum(int ReleaseYear, string Album)
        {
            ConectionDB x = new ConectionDB();
            return x.ADDALBUM(Album,ReleaseYear).OpMesssage;
        }

        public List<Song> GetSearchGenListSong(string Genre)
        {
            //Conection to DB Instance
            ConectionDB conn = new ConectionDB();
            //use the method of ListGen
            return conn.ListGen(Genre).OpResult;
        }

        public OperationResult<int> InsertSong(Song song)
        {
            ConectionDB conn = new ConectionDB();
            return conn.InsertSong(song);
        }

        public List<SongArtist> GetListSongContract(string Artist)
        {
            //Conection to DB
            ConectionDB Conn = new ConectionDB();
            //Use of Methods of Conn return a List of Songs
            return  Conn.ListArtist(Artist);
        }

        //Devuelve la canción más sonada

        public List<int> CreateUser()
        {
            List<int> _Songs = new List<int>() { };

            UserDataManager Cancion = new UserDataManager();

            _Songs = Cancion.CancionMasSonada();

            return _Songs;
        }


        //Muestra en que playlist esta la cancion seleccionada

        public List<string> CreateUser1(int IdCancion)
        {
            List<string> _Canciones = new List<string>() { };

            UserDataManager userDatamanager = new UserDataManager();

            _Canciones = userDatamanager.CancionEnMasPlaylist(IdCancion);

            return _Canciones;

        }
    }
}

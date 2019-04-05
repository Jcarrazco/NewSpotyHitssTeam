using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SpotyHitss.Data.Manager;
using SpotyHitss.Data.Objects;

namespace NewSpotyHitss
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {     
        public List<Song> GetListSongContract(string Gender)
        {
            //Conection to DB
            ConectionDB Conn = new ConectionDB();
            //Use of Methods of Conn return a List of Songs
            return  Conn.ListGen(Gender);
        }

        public OperationResult<int> InsertSong(Song song)
        {
            ConectionDB conn = new ConectionDB();
            return conn.InsertSong(song);
        }
    }
}

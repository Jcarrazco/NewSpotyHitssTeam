using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SpotyHitss.Data.Objects;

namespace NewSpotyHitss
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // TODO: Add your service operations here
        
        //Operation Get List of Songs by Gen
        [OperationContract]
        List<Song> GetSearchGenListSong(string Genre);

        [OperationContract]
        OperationResult<int> InsertSong(Song song);
    }
}

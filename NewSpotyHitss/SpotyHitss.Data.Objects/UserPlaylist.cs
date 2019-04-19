using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Apis.Data.DataObjects
{

    [Serializable]
    public class UserPlaylist
    {
        public string UserId { get; set; }

        public string PlaylistId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SpotyHitss.Data.Objects
{
    [DataContract]
    public class Song
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Year { get; set; }

        [DataMember]
        public string Genre { get; set; }

        [DataMember]
        public Byte[] DataSong { get; set; }

        [DataMember]
        public string ArtistName { get; set; }
    }
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SpotyHitss.Data.Objects
{
    
    public class Song
    {
        
        public int Id { get; set; }

        
        public string Name { get; set; }

        
        public int Year { get; set; }

        
        public string Genre { get; set; }

        
        public Byte[] DataSong { get; set; }

        
        public string ArtistName { get; set; }
    }
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

    }

}
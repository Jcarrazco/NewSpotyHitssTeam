using System;
using System.Collections.Generic;
using System.Linq;

namespace SpotyHitss.Data.Objects
{
    public class SongArtist
    {
        public int ID_Artist { get; set; }
        public String Artist_Name { get; set; }
        public int ID_Song { get; set; }
        public String Song_Name { get; set; }
    }
}
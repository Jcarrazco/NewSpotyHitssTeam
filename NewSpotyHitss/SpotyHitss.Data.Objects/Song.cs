using System;
using System.Collections.Generic;
using System.Linq;

namespace SpotyHitss.Data.Objects
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
    }
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

    }

}
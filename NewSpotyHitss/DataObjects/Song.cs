using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace NewSpotyHitss
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
    }
}
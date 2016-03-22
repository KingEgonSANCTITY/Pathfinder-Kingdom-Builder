using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models
{
    public class Special_Terrain
    {
        public string name { get; set; }
        public string notes { get; set; }
        public Settlement_Attributes settlement_attributes { get; set; }
    }
}
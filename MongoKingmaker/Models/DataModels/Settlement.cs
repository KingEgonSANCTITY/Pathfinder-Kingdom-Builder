using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models
{
    public class Settlement
    {
        public string name { get; set; }
        public List<District> districts { get; set; }
    }
}
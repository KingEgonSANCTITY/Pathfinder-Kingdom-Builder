using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models
{
    public class Hex
    {
        [Required]
        [Display(Name = "Location")]
        public string location { get; set; }

        [Required]
        [Display(Name = "Terrain Type")]
        public string terrain { get; set; }

        [BsonIgnoreIfNull]
        public List<Terrain_Improvement> terrain_improvements { get; set; }

        [BsonIgnoreIfNull]
        public List<Special_Terrain> special_terrains { get; set; }

        [BsonIgnoreIfNull]
        public List<Settlement> settlements { get; set; }
    }
}
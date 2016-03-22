using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models
{
    public class District
    {
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Buildings")]
        [BsonIgnoreIfNull]
        public List<Building> buildings { get; set; }
    }
}
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models
{
    public class Terrain_Improvement
    {
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Name")]
        public bool unique { get; set; }

        [Required]
        [Display(Name = "Name")]
        public List<float> cost { get; set; }

        [Required]
        [Display(Name = "Name")]
        public List<string> terrain { get; set; }

        [Display(Name = "Name")]
        [BsonIgnoreIfNull]
        public Settlement_Attributes settlement_attributes { get; set; }
    }
}
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoKingmaker.Models.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models
{
    public class Kingdom
    {
        public Kingdom()
        {
            alignments = new List<Alignment>() { };
            kingdom_statistics = new Kingdom_Statistics
            {
                Consumption = 0,
                Control_DC = 0,
                Economy = 0,
                Loyalty = 0,
                Size = 0,
                Stability = 0,
                Treasury = 0,
                Turn = 0,
                Unrest =  0
            };
            leaders = new List<Leader>() { };
            hexes = new List<Hex>() { };
        }
        public ObjectId _id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Alignment")]
        public List<Alignment> alignments { get; set; }

        [Display(Name = "Kingdom Statistics")]
        public Kingdom_Statistics kingdom_statistics { get; set; }

        [Display(Name = "Leaders")]
        public List<Leader> leaders { get; set; }

        [Display(Name = "Hexes")]
        public List<Hex> hexes { get; set; }
    }
}
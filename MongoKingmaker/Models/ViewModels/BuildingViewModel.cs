using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models
{
    public class BuildingViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Cost")]
        [BsonRepresentation(BsonType.Double)]
        public float cost { get; set; }

        [Required]
        [Display(Name = "Lots")]
        [BsonRepresentation(BsonType.Double)]
        public float lots { get; set; }

        [Display(Name = "Discounts")]
        [DisplayFormat(NullDisplayText = "No Discounts")]
        public List<string> discounts { get; set; }

        [Display(Name = "Limits")]
        [DisplayFormat(NullDisplayText = "No Limits")]
        public string limit { get; set; }

        [Display(Name = "Upgrades To")]
        [DisplayFormat(NullDisplayText = "No Upgrades")]
        public string upgrade_to { get; set; }

        [Display(Name = "Upgraded From")]
        [DisplayFormat(NullDisplayText = "No Downgrades")]
        public string upgrade_from { get; set; }

        [Display(Name = "Settlement Attributes")]
        [DisplayFormat(NullDisplayText = "No Settlement Attributes")]
        public Settlement_Attributes settlement_attributes { get; set; }

        [Display(Name = "Kingdom Attributes")]
        [DisplayFormat(NullDisplayText = "No Kingdom Attributes")]
        public Kingdom_Attributes kingdom_attributes { get; set; }
    }
}
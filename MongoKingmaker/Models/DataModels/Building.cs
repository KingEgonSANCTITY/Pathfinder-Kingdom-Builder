using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models
{
    [MetadataType(typeof(BuildingViewModel))]
    public class Building
    {
        public string name { get; set; }
        public float cost { get; set; }
        public float lots { get; set; }

        [BsonIgnoreIfNull]
        public List<string> discounts { get; set; }

        [BsonIgnoreIfNull]
        public string limit { get; set; }

        [BsonIgnoreIfNull]
        public string upgrade_to { get; set; }

        [BsonIgnoreIfNull]
        public string upgrade_from { get; set; }

        [BsonIgnoreIfNull]
        public Settlement_Attributes settlement_attributes { get; set; }

        [BsonIgnoreIfNull]
        public Kingdom_Attributes kingdom_attributes { get; set; }
    }
}
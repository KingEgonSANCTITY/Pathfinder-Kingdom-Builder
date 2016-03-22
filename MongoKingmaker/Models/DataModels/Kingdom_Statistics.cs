using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models.DataModels
{
    public class Kingdom_Statistics
    {
        [Display(Name = "Economy")]
        [BsonRepresentation(BsonType.Double)]
        public float Economy { get; set; }

        [Display(Name = "Loyalty")]
        [BsonRepresentation(BsonType.Double)]
        public float Loyalty { get; set; }

        [Display(Name = "Stability")]
        [BsonRepresentation(BsonType.Double)]
        public float Stability { get; set; }

        [Display(Name = "Control DC")]
        [BsonRepresentation(BsonType.Double)]
        public float Control_DC { get; set; }

        [Display(Name = "Treasury")]
        [BsonRepresentation(BsonType.Double)]
        public float Treasury { get; set; }

        [Display(Name = "Unrest")]
        [BsonRepresentation(BsonType.Double)]
        public float Unrest { get; set; }

        [Display(Name = "Consumption")]
        [BsonRepresentation(BsonType.Double)]
        public float Consumption { get; set; }

        [Display(Name = "Size")]
        [BsonRepresentation(BsonType.Double)]
        public float Size { get; set; }

        [Display(Name = "Turn")]
        [BsonRepresentation(BsonType.Double)]
        public float Turn { get; set; }
    }
}
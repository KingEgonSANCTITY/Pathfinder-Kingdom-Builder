using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models
{
    [BsonIgnoreExtraElements]
    public class Kingdom_Attributes
    {
        [BsonRepresentation(BsonType.Double)]
        [BsonIgnoreIfNull]
        public float? economy { get; set; }

        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.Double)]
        public float? loyalty { get; set; }

        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.Double)]
        public float? stability { get; set; }

        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.Double)]
        public float? defense { get; set; }

        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.Double)]
        public float? unrest { get; set; }

        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.Double)]
        public float? fame { get; set; }
    }
}
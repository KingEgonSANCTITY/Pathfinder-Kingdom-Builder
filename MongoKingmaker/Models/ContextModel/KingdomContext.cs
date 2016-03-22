using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models.ContextModel
{
    public class KingdomContext
    {
        public const string CONNECTION_STRING_NAME = "Kingdom";
        public const string DATABASE_NAME = "Kingships";
        public const string BUILDINGS_COLLECTION_NAME = "Buildings";
        public const string KINGDOMS_COLLECTION_NAME = "Kingdoms";
        public const string ALIGNMENTS_COLLECTION_NAME = "Alignments";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static KingdomContext()
        {
            var connectionString = ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(DATABASE_NAME);
        }

        public IMongoClient Client
        {
            get { return _client; }
        }

        public IMongoCollection<Kingdom> Kingdoms
        {
            get { return _database.GetCollection<Kingdom>(KINGDOMS_COLLECTION_NAME); }
        }

        public IMongoCollection<Alignment> Alignments
        {
            get { return _database.GetCollection<Alignment>(ALIGNMENTS_COLLECTION_NAME); }
        }

        public IMongoCollection<Building> Buildings
        {
            get { return _database.GetCollection<Building>(BUILDINGS_COLLECTION_NAME); }
        }
    }
}
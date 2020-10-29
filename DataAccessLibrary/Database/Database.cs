using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    class Database
    {
        //private readonly IMongoDatabase _database;

        public IMongoCollection<PensionerModel> PensionerCollection { get; private set; }

        private const string PENSIONER_COLLECTION = "pensioners";
        public IMongoCollection<YoungAdultModel> YoungAdultCollection { get; private set; }

        private const string YOUNGADULT_COLLECTION = "young-adult";

        public Database()
        {

            MongoClient client = new MongoClient("mongodb+srv://admin:Abc123@cluster0.spjb5.mongodb.net/hultas-bilverkstad?retryWrites=true&w=majority");
            var _database = client.GetDatabase("hultas-bilverkstad");
            PensionerCollection = _database.GetCollection<PensionerModel>(PENSIONER_COLLECTION);
            YoungAdultCollection = _database.GetCollection<YoungAdultModel>(YOUNGADULT_COLLECTION);
        }




    }
}

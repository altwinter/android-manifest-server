using System;
using MongoDB.Driver;

namespace Mongo
{
    class MongoData
    {
        private MongoData(){}

        public static void Send(string manifestJson)
        {
            // Put this information into a config file
            MongoClient dbClient = new MongoClient("mongodb://admin:password@localhost:27017");
            var database = dbClient.GetDatabase("Application");

            // var coll = database.GetCollection<Comet>("comets");

            // coll.InsertMany(comets);
            
            // var dbList = dbClient.ListDatabases().ToList();

            // Console.WriteLine("The list of databases on this server is: ");
            // foreach (var db in dbList)
            // {
            //     Console.WriteLine(db);
            // }
        }
    }
}

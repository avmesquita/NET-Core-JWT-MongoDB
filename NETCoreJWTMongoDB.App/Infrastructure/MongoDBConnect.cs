using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreJWTMongoDB.App.Infrastructure
{
    public class MongoDBConnect : IDisposable
    {
        public IMongoClient client;
        public IMongoDatabase database;

        public MongoDBConnect()
        {
            client = new MongoClient("mongodb://localhost");
            database = client.GetDatabase("dbo");
        }

        public void Dispose()
        {
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}

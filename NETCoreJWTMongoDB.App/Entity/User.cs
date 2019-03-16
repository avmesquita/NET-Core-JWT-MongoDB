using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NETCoreJWTMongoDB.App.Entity
{
    public class User
    {
        [BsonId()]        
        public ObjectId Id { get; set; }

        [BsonElement("UserID")]
        public string UserID { get; set; }

        [BsonElement("AccessKey")]
        public string AccessKey { get; set; }
    }
}

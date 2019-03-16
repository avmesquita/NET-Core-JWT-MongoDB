using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using NETCoreJWTMongoDB.App.Entity;
using NETCoreJWTMongoDB.App.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NETCoreJWTMongoDB.App.Data
{
    public class UserDAO : MongoDBConnect
    {
        private IConfiguration _configuration;

        public UserDAO(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public User Find(string userID)
        {
            var usuarios = this.database.GetCollection<User>("Users");

            //Expression<Func<User, bool>> filtro = x => x.Id.Equals(ObjectId.Parse(userID));
            Expression<Func<User, bool>> filtro = x => x.UserID == userID;

            IList<User> triagem = usuarios.Find(filtro).ToList();

            var usuario = triagem.Where(x => x.UserID == userID).FirstOrDefault();

            return usuario;
        }
    }
}

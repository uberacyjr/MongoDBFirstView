using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBFirstLook
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient();
            var db = client.GetDatabase("Teste");
            var coll = db.GetCollection<Pessoa>("Pessoa");
            var pessoas = coll.Find<Pessoa>(x=>true).ToList();
        }
        public class Pessoa
        {
            public ObjectId _id { get; set; }
            public string Nome { get; set; }
        }
    }
}

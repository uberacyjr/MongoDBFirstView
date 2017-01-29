using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            var collc = db.GetCollection<Carro>("Carros");

            
            var pessoas = coll.Find(x=>true).ToList();
            

        }
        public class Pessoa 
        {
            public ObjectId _id { get; set; }
            public string Nome { get; set; }

            public ObjectId Carros { get; set; }

            public Carro carro { get; set; }

        }
        public class Carro
        {
            public ObjectId _id { get; set; }
            public string Nome { get; set; }
        }
    }
}

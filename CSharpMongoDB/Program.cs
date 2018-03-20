using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace CSharpMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int count = 1;
                Console.WriteLine("***Connecting to mongodb://localhost:27017....***");
                MongoClient client = new MongoClient("mongodb://localhost:27017");
                List <BsonDocument> listDatabase = client.ListDatabases().ToList();
               
                Console.WriteLine("***List of exiting Database***");
                foreach (var item in listDatabase)
                {
                    Console.WriteLine(count+": "+item["name"]);
                    count++;
                }
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("***Incorrect address***");
            }
           
        }
    }
}

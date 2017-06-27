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
            Console.WriteLine("Enter the address of the mongodb server, for example: mongodb://localhost:27017");
            string stringConnection = Console.ReadLine();
            try
            {
                MongoClient client = new MongoClient(stringConnection);
                List<BsonDocument> listDatabase = client.ListDatabases().ToList();
               
                Console.WriteLine("***List of exiting Database***");
                foreach (var item in listDatabase)
                {
                    Console.WriteLine(item["name"]);
                }
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect address");
            }
           
        }
    }
}

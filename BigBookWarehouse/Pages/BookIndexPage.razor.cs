using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using IdentityServer4.Models;
using BigBookWarehouse.DAL.Models.Books;

namespace BigBookWarehouse.Web.Pages
{
    public partial class BookIndexPage
    {
        static void Main(string[] args)
        {
            var DbClient = new MongoClient("mongodb://127.0.0.1:27017");

            var database = Client.GetDatabase("BigBookWarehouse");
            var collection = database.GetCollection<Book>("books");

        }
    }
}

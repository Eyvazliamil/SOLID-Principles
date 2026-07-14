using Dependency_Inversion_Principle.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Classes
{
    public class SqlDatabase : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"{data} saved to SQL Database");
        }
    }

    public class MongoDatabase : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"{data} saved to MongoDB");
        }
    }

    public class UserService
    {
        private readonly IDatabase _database;

        public UserService(IDatabase database)
        {
            _database = database;
        }

        public void CreateUser(string username)
        {
            _database.Save(username);
        }
    }
}

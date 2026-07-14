using Dependency_Inversion_Principle.Classes;
using Dependency_Inversion_Principle.Interface;

class Program
{
    static void Main()
    {
        IDatabase database = new SqlDatabase(); 
        UserService userService = new UserService(database);

        userService.CreateUser("Mike");
         
        IDatabase mongo = new MongoDatabase(); 
        userService = new UserService(mongo); 
        userService.CreateUser("Thomas");
    }
}
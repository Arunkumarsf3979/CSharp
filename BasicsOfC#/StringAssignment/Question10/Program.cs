using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        string username;
        string password;
        do{
            Console.Write("enter the username: ");
            username=Console.ReadLine();
            Console.Write("enter the password: ");
            password=Console.ReadLine();
            if(!username.Equals("user")||!password.Equals("pass"))
            {
                Console.WriteLine("invalid user or password");
            }
        }while(!username.Equals("user")||!password.Equals("pass"));
        Console.Write("Password entered successfully");
    }
}
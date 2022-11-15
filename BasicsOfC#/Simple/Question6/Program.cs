using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the password: ");
        String password=Console.ReadLine();
        if(password.Equals("s3cr3t!P@ssw0rd")){
            Console.WriteLine("Welcome");
        }
        else {
            Console.WriteLine("Wrong password");
        }
    }
}
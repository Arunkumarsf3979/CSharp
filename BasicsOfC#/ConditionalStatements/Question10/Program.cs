using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the password :");
        String password=Console.ReadLine();
        if(password=="HiTeam")
        {
            Console.WriteLine("Right password");
        }
        else
        {
            Console.WriteLine("Wrong Password");
        }
    }
}
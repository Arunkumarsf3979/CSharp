
using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age=Convert.ToInt32(Console.ReadLine());
        if(age>=18)
        {
            Console.WriteLine("Congratulation!You are eligible for casting your vote.");
        }
        else{
            Console.WriteLine("Not eligible for vote");
        }
    }
}
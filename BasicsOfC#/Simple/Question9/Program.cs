using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter name of the month: ");
        string month=Console.ReadLine().ToLower();
        Console.Write("Enter the number of leaves taken: ");
        float leave=Convert.ToSingle(Console.ReadLine());
        if(month=="january"|| month=="march"|| month=="may"|| month=="july"|| month=="august"|| month=="october"|| month=="december")
        {
            Console.WriteLine($"Salary is {500*(31-leave)}");
        }
        else if(month=="february")
        {
            Console.WriteLine($"Salary is {500*(28-leave)}");
        }
        else{
            Console.WriteLine($"Salary is {500*(30-leave)}");
        }
    }
}
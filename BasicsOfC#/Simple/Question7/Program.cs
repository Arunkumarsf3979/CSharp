using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the input: ");
        int num=Convert.ToInt32(Console.ReadLine());
        if(num<100)
        {
            Console.WriteLine("Less than 100");
        }
        else if(num>=100 && num<200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else{
            Console.WriteLine("Greater than 200");
        }
    }
}
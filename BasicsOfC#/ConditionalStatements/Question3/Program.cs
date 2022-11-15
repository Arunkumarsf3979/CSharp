using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the year: ");
        int year=Convert.ToInt32(Console.ReadLine());
        if(year%400==0 || (year%4==0 && year%100!=0))
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else{
            Console.WriteLine($"{year} is not a leap year"); 
        }
    }
}
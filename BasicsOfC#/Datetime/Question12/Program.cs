using System;
namespace Question12;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter a month: ");
        int month=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter a year: ");
        int year=Convert.ToInt32(Console.ReadLine());
        Console.Write("the number of days in the given month: ");
        Console.Write(DateTime.DaysInMonth(year,month));
    }
}
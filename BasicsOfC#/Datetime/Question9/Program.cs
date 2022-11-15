using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter the starting year: ");
        int year1=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the ending year: ");
        int year2=Convert.ToInt32(Console.ReadLine());
        for (int year=year1; year<=year2; year++)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year.", year);
                DateTime leapyear= new DateTime(year, 2, 29);
                DateTime nextYear = leapyear.AddYears(1);
                Console.WriteLine($"One year from {leapyear.ToString("d")} is {nextYear.ToString("d")}.");
            }         
        }
    }
}
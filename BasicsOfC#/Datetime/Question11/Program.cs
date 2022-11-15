using System;
namespace Question11;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Display the name of the months of a year : ");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"The date of today {DateTime.Today}");
        Console.WriteLine(DateTime.Today.ToString("MMMMMM"));
        DateTime newDate=DateTime.Today;
        for(int i=0;i<11;i++)
        {
            newDate=newDate.AddMonths(1);
            Console.WriteLine(newDate.ToString("MMMMMM"));
        }
    }
}
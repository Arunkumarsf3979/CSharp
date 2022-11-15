using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        DateTime newDate=new DateTime();
        Console.Write("Enter the date in dd/MM/yyyy HH:mm:ss tt :");
        newDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss tt",null);
        Console.WriteLine($"1.Complete Date: {newDate.ToString("dd/MM/yyyy HH:mm:ss tt")}");
        Console.WriteLine($"2.ShortDate: {newDate.ToShortDateString()}");
        Console.WriteLine($"3.LongDate: {newDate.ToString("ddddd, MMMM yyyy HH:mm:ss tt")}");
        Console.WriteLine($"4.To 12 hour format {newDate.ToString("dd/MM/yyyy hh:mm:ss tt")}");
        Console.WriteLine($"5.To date only {newDate.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"6.To time only {newDate.ToString("hh:mm:ss tt")}");
    }
}
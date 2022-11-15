using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        DateTime newDate=new DateTime();
        Console.Write("Enter date: ");
        newDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss tt",null);
        Console.WriteLine($"Year: {newDate.Year}");
        Console.WriteLine($"Month: {newDate.Month}");
        Console.WriteLine($"Day: {newDate.Day}");
        Console.WriteLine($"Hour: {newDate.Hour}");
        Console.WriteLine($"Minutes: {newDate.Minute}");
        Console.WriteLine($"Seconds: {newDate.Second}");
        Console.WriteLine($"Millisecond: {newDate.Millisecond}");
    }
}
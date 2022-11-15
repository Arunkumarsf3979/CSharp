using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        DateTime newDate=DateTime.Today;
        // TimeSpan newTime=
        Console.WriteLine("Yesterday "+newDate.AddDays(-1).ToString("dd/MM/yyyy"));
        Console.WriteLine("tomorrow "+newDate.AddDays(1).ToString("dd/MM/yyyy"));
        
    }
}
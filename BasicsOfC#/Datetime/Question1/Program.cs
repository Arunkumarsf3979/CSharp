using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        DateTime[] dates = { DateTime.Now, new DateTime(2016, 8, 16, 9, 28, 0),
                            new DateTime(2011, 5, 28, 10, 35, 0),new DateTime(1979, 12, 25, 14, 30, 0) };
        foreach(DateTime var in dates)
        {
            Console.WriteLine($"Day: {var.ToString("MM/dd/yyyy")} Time: {var.ToString("HH:mm:ss")}");
            Console.WriteLine($"Day: {var.ToString("MM/dd/yyyy")} Time: {var.ToString("hh:mm tt")}");
            Console.WriteLine();
        }
    }
}
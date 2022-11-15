using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the INR: ");
        float inr=Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($"USD :{inr*1.22/100}");
        Console.WriteLine($"EUR :{inr*1.27/100}");
        Console.WriteLine($"CNY: {inr*8.79/100}");
    }
}
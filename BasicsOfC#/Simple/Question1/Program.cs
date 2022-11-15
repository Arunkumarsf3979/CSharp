using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the input: ");
        double num=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The given number {num}inch and converted to {num*2.54}cm");
    }
}
using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the celcius: ");
        double celcius=Convert.ToDouble(Console.ReadLine());
        double fahrenheit=celcius*9/5+32;
        Console.Write("Fahrenheit is "+Math.Round(fahrenheit,2));

    }
}
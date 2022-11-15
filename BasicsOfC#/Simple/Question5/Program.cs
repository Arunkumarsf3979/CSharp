using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the basic salary: ");
        double salary=Convert.ToInt32(Console.ReadLine());
        double annualSalary=(salary+salary*0.10+salary*0.10)*12;

        Console.WriteLine($"Annual Income: {annualSalary-0.05*annualSalary}");
    }
}
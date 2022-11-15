using System;
namespace Question14;
class Program{
    public static void Main(string[] args)
    {
        
        Console.Write("enter a month: ");
        int month=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter number of leaves: ");
        int leave=Convert.ToInt32(Console.ReadLine());
        int days=DateTime.DaysInMonth(2022,month);
        Console.WriteLine("Salary is "+(500*(days-leave)));
    }
}
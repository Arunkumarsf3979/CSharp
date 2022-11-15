using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        FullTimeEmployee employee1=new FullTimeEmployee("Arun",Gender.Male,24);
        System.Console.WriteLine("Full time employee");
        employee1.DisplaySalary();

        PartTimeEmployee employee2=new PartTimeEmployee("Ajith",Gender.Male,26);
        System.Console.WriteLine("Part Time employee");
        employee2.DisplaySalary();
    }
}

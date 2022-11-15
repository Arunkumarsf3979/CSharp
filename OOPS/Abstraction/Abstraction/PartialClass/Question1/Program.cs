using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Employee employee=new Employee("Arun",Gender.Male,new DateTime(2022,10,17),6383325297);
        System.Console.WriteLine("                   Before Update Info");
        employee.Display();
        employee.Update("Ajith",Gender.Male,new DateTime(2016,09,09),9003112190);
        System.Console.WriteLine("                   After Update Info");
        employee.Display();
    }
}
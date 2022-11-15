using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Syncfusion employee=new Syncfusion("Arun","ragu",Gender.Male,"B.Tech","Developer",25,"Chennai");
        employee.Display();
        employee.CalculateSalary();
        System.Console.WriteLine("Salary amount : "+employee.SalaryAmount);
    }
}
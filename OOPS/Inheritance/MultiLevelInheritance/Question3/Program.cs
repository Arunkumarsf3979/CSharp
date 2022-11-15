using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo(300,"Feb","Arun","98089980","jkdjfi",Gender.Male,300,"Chennai",5);
        employee.CalculateSalary();
        employee.DisplaySalary();
        employee.ShowDetails();
    }
}
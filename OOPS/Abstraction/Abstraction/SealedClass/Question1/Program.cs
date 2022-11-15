using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo("arun10");
        System.Console.WriteLine("Before update");
        employee.DisplayInfo();
        System.Console.WriteLine("After Update");
        employee.UpdateInfo("ajith10");
        employee.DisplayInfo();
    }
}

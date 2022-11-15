using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Attendance month1=new Attendance(31,2,0);
        Attendance month2=new Attendance(30,1,1);
        Attendance month3=new Attendance(29,2,0);
        System.Console.WriteLine("Salary for month1 "+month1.TotalSalary());
        System.Console.WriteLine("Salary for month2 "+month2.TotalSalary());
        System.Console.WriteLine("Salary for month3 "+month3.TotalSalary());
    }
}
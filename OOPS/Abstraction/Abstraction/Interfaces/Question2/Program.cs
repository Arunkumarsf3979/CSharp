using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Arun","Ragu","988493290");
        EmployeeInfo employee=new EmployeeInfo("Ajith","Ragu");
        student.Display();
        employee.Display();
    }
}
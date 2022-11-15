using System;
namespace Question1;
public delegate void Student();
class Program{
    public static event Student calculate,getDetails;
    public static void Main(string[] args)
    {
        StudentDetails student=new StudentDetails(45,87,98);
        getDetails=new Student(student.GetDetails);
        calculate=new Student(student.Calculate);
        getDetails();
        calculate();
    }
}
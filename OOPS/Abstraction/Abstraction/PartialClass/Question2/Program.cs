using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Student student=new Student("Arun",6383325297,Gender.Male,new DateTime(2001,04,04),97,98,100);
        student.Display();
        Console.WriteLine("Percentage  "+student.CalculatePercentage());
        System.Console.WriteLine("Total   :"+student.Total());
    }
}
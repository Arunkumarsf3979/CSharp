using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Semester sem1=new Semester(98,89,78,67,45,89);
        Semester sem2=new Semester(78,79,60,99,79,45);
        Semester sem3=new Semester(98,87,78,67,45,89);
        Semester sem4=new Semester(93,91,78,67,45,85);
        Semester firstTwoSem=sem1+sem2;
        Semester LastTwoSem=sem3+sem4;
        Semester totalSem=firstTwoSem+LastTwoSem;
        System.Console.WriteLine("Total Marks "+totalSem.TotalMarks);
        System.Console.WriteLine("Total Percentage "+totalSem.Percentage);
        // System.Console.WriteLine(firstTwoSem.TotalMarks);
    }
    
}

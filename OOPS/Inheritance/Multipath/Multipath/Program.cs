using System;
namespace Multipath;
class Program{
    public static void Main(string[] args)
    {
        Student student1=new Student("Stefan",89,98);
        Console.WriteLine(student1.AcadamicMark);
        student1.Display();
        // System.Console.WriteLine(student1.);

    }
}

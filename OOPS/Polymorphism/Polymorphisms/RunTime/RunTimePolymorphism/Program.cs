using System;
namespace RunTimePolymorphism;
class Student{
    public string  Name{get;set;}
    public int TotalMarks { get; set; }
    public virtual void Display(){}
}
class Sport:Student
{
    public int SportMark=50;
    public override void Display()
    {
        System.Console.WriteLine("Name :"+Name +"mark"+SportMark);
    }
}
class Total:Sport
{
    public int AcadamicMark=90;
    public string StudentName{get;set;}
    public override void Display()
    {
        TotalMarks=AcadamicMark+SportMark;
        System.Console.WriteLine("TotalMarks"+TotalMarks);
    }
}

class Program{
    public static void Main(string[] args)
    {
        Total total
    }
}
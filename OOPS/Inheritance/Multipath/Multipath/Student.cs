using System;
namespace Multipath
{
    public class Student
    {
        public int AcadamicMark { get; set; }
        public string Name { get; set; }
        public int SportMark { get; set; }
        public Student(string name,int acadamicMark,int sportMark)
        {
            Name=name;
            AcadamicMark=acadamicMark;
            SportMark=sportMark;
        }
        public void Display()
        {
            Console.WriteLine("Name :"+Name);
            System.Console.WriteLine("TotalMark  :"+(AcadamicMark+SportMark));
        }
    }
}
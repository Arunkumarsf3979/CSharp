using System;
using System.Collections.Generic;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        List<HSCDetails> studentList=new List<HSCDetails>();
        HSCDetails student1=new HSCDetails("stefan","salvatore","674343782","stefan@mail.com",new DateTime(2001,04,04),Gender.Male,2018308006,"fifth","Pharma",new DateTime(2022),9934983,98,99,100);
        HSCDetails student2=new HSCDetails("damon","salvatore","674343782","daman@mail.com",new DateTime(2001,04,04),Gender.Male,2018308007,"fifth","Pharma",new DateTime(2022),9934983,98,99,100);
        studentList.Add(student1);
        studentList.Add(student2);
        foreach(HSCDetails student in studentList)
        {
            if(student.RegisterNumber==2018308006)
            {
                System.Console.WriteLine("-------------------before update-----------------");
                student.ShowInfo();
                student.UpdateInfo("damon","salvatore","674343782","daman@mail.com",new DateTime(2001,04,04),Gender.Male,2018308007,"fifth","Pharma",new DateTime(2022));
                System.Console.WriteLine("--------------------after update---------------------");
                student.ShowInfo();
                student.TotalMarks();
                student.Percentage();
                student.ShowMarksheet();
            }
        }
    }
}
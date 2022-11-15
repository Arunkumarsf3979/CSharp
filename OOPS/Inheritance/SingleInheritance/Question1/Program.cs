using System;
using System.Collections.Generic;
namespace Question1;
class Program{
    static List<StudentInfo> studentList=new List<StudentInfo>();
    public static void Main(string[] args)
    {
        // PersonalInfo person1=new PersonalInfo("Stefan","Salvatore","8942730230","stefan@mail.com",Gender.Male);
        // PersonalInfo person2=new PersonalInfo("Damon","Salvatore","894273430","damon@mail.com",Gender.Male);
        List<StudentInfo> studentList=new List<StudentInfo>();

        StudentInfo student1=new StudentInfo("Stefan","Salvatore","8942730230","stefan@mail.com",Gender.Male,2018308006,"Fifth","Pharma",AcademicYear.I);
        StudentInfo student2=new StudentInfo("Damon","Salvatore","894273430","damon@mail.com",Gender.Male,2018308007,"first","Pharma",AcademicYear.II);
        studentList.Add(student1);
        studentList.Add(student2);

        foreach(StudentInfo student in studentList)
        {
            if(student.RegisterNumber==2018308006)
            {
                System.Console.WriteLine("----------------before update-----------------");
                student.ShowInfo();
                student.UpdateInfo("Damon","Salvatore","894273430","damon@mail.com",Gender.Male,"first","Pharma",AcademicYear.II);
                System.Console.WriteLine("--------------------after update-------------------");
                student.ShowInfo();
            }
        }
    }
}
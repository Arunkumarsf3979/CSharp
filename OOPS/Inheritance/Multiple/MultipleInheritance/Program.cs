﻿using System;
namespace MultipleInheritance;
class Program{
    public static void Main(string[] args)
    {
        PersonalDetails person1=new PersonalDetails("stefan","salvatore",Gender.Male,new DateTime(2001,04,05));
        person1.ShowDetails();
        StudentDetails student1=new StudentDetails("AID1001","stefan","salvatore",Gender.Male,new DateTime(2001,04,05),Department.ECE,Year.I);
        student1.ShowDetails();
        student1.getMarkDetails(89.8);
        System.Console.WriteLine(student1.CGPA);
    }
}
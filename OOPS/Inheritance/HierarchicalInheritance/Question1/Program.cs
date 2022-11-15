using System;
using System.Collections.Generic;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        // PersonalInfo person1=new PersonalInfo("Stefan","Salvatore","8942730230","stefan@mail.com",Gender.Male);
        // PersonalInfo person2=new PersonalInfo("Damon","Salvatore","894273430","damon@mail.com",Gender.Male);
        List<StudentInfo>studentList=new List<StudentInfo>();
        List<Teacher>teacherList=new List<Teacher>();
        List<PrincipalInfo>principalList=new List<PrincipalInfo>();
        StudentInfo student1=new StudentInfo("Stefan","Salvatore","8942730230","stefan@mail.com",Gender.Male,"B.E","ECE","I");
        StudentInfo student2=new StudentInfo("Damon","Salvatore","894273430","damon@mail.com",Gender.Male,"B.E","ECE","I");
        studentList.Add(student1);
        studentList.Add(student2);

        Teacher teacher1=new Teacher("Elena","Gilbert","983438483","elena@gmail.com",Gender.Female,"EEE","Digital Processing","B.TECH",5,new DateTime(2022,05,05));
        Teacher teacher2=new Teacher("Caroline","Gilbert","983999483","caroline@gmail.com",Gender.Female,"EEE","Digital Processing","B.TECH",5,new DateTime(2022,05,05));
        teacherList.Add(teacher1);
        teacherList.Add(teacher2);

        PrincipalInfo principal1=new PrincipalInfo("Mathew","wade","98398430","mathew@mail.com",Gender.Male,"CSE",6,new DateTime(2016,04,04));
        PrincipalInfo principal2=new PrincipalInfo("Arron","finch","983999430","finch@mail.com",Gender.Male,"CSE",6,new DateTime(2016,04,04));
        principalList.Add(principal1);
        principalList.Add(principal2);

        foreach(StudentInfo student in studentList)
        {
            if(student.StudentID=="SID1001")
            {
                System.Console.WriteLine("-------------------Before update----------------");
                student.ShowStudentInfo();
                System.Console.WriteLine("---------------After update---------------");
                student.Update("Stefan","Salvatore","8942730230","stefan@mail.com",Gender.Male,"B.TECH","Bio tech","I");
                student.ShowStudentInfo();
            }
        }
        foreach(PrincipalInfo principal in principalList)
        {
            System.Console.WriteLine(principal.PrincipalID);
            if(principal.PrincipalID=="PID1002")
            {
                System.Console.WriteLine("------------------Before update---------------");
                principal.ShowInfo();
                principal.Update("Arron","finch","983999430","finch@mail.com",Gender.Male,"CSE",6,new DateTime(2016,04,04));
                System.Console.WriteLine("--------------------After update-----------------");
                principal.ShowInfo();
            }
        }
        foreach(Teacher teacher in teacherList)
        {
            if(teacher.TeacherID=="TID1001")
            {
                System.Console.WriteLine("-----------------------Before update----------------");
                teacher.ShowInfo();
                teacher.Update("Caroline","Gilbert","983999483","caroline@gmail.com",Gender.Female,"EEE","Digital Processing","B.TECH",5,new DateTime(2022,05,05));
                System.Console.WriteLine("-------------------After update---------------------");
                teacher.ShowInfo();
            }
        }



    }
}
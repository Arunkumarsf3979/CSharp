using System;
namespace HybridInheritance;
class Program{
    public static void Main(string[] args)
    {
        // PersonalDetails person1=new PersonalDetails("stefan","salvatore",Gender.Male,new DateTime(2001,04,05));
        // person1.ShowDetails();
        // StudentDetails student1=new StudentDetails("AID1001","stefan","salvatore",Gender.Male,new DateTime(2001,04,05),Department.ECE,Year.I);
        // person1.ShowDetails();
        // person1.getMarkDetails(89.8);
        // System.Console.WriteLine(student1.CGPA);
        EmploymentDetails employee=new EmploymentDetails("SID1001","AID2001","stefan","salvatore",Gender.Male,new DateTime(2001,04,05),Department.ECE,new DateTime(2022,10,17));
        employee.ShowDetails();
        employee.getMarkDetails(89.5);
        employee.ShowEmployeeInfo();

    }
}

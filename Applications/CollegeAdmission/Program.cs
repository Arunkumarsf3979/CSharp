using System;
using System.Collections.Generic;
namespace CollegeAdmission;
class Program{
    public static void Main(string[] args)
    {
        
        List<StudentDetails> studentList=new List<StudentDetails>();
        string condition;
        do{
            
            Console.Write("Enter your name: ");
            string name=Console.ReadLine();
            Console.Write("Enter your father name: ");
            string fatherName=Console.ReadLine();
            Console.Write("Enter your date of birth: ");
            DateOnly dob=DateOnly.Parse(Console.ReadLine());
            Console.Write("Select the gender option: Male,Female,Transgender ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

            Console.Write("Enter your mailID: ");
            string mailId=Console.ReadLine();
            Console.Write("Enter your physics mark: ");
            int physicsMark=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your chemistry mark: ");
            int chemistryMark=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your maths mark: ");
            int mathsMark=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Details entered successfully: ");
            StudentDetails student1=new StudentDetails(name,fatherName,dob,gender,mailId,physicsMark,chemistryMark,mathsMark);
            studentList.Add(student1);
            Console.WriteLine("RegistrationID :"+student1.RegistrationId);
            Console.Write("Next user yes or no: ");
            condition=Console.ReadLine().ToLower();
        }while(condition=="yes");

        System.Console.Write("Enter your registrationID: ");
        string registrationID=Console.ReadLine().ToUpper();

         // Showing details
        foreach(StudentDetails student in studentList)
        {
            if(registrationID==student.RegistrationId)
            {
                System.Console.WriteLine("User found");
                ShowDetails(student);
                // bool eligible=student.Eligibility(75);
                // if(eligible)
                // {
                //     System.Console.WriteLine("You are eligible");
                // }
                // else{
                //     System.Console.WriteLine("Your are not eligible");
                // }
            }
            
        }
        void ShowDetails(StudentDetails student)
        {
            System.Console.WriteLine("Student Details");
            System.Console.WriteLine($"Student name     : {student.StudentName}");
            System.Console.WriteLine($"Father name      : {student.FatherName}");
            System.Console.WriteLine($"DOB              : {student.DOB}");
            System.Console.WriteLine($"Gender           : {student.StudentGender}");
            System.Console.WriteLine($"MailID           : {student.MailId}");
            System.Console.WriteLine($"Physics mark     : {student.PhysicsMark}");
            System.Console.WriteLine($"Chemistry mark   : {student.ChemistryMark}");
            System.Console.WriteLine($"Maths mark       : {student.MathsMark}");
            System.Console.WriteLine($"Registration ID  :{student.RegistrationId}");
        }
        

        // StudentDetails student2=new StudentDetails();
        // Console.Write("Enter your name: ");
        // student2.StudentName=Console.ReadLine();
        // Console.Write("Enter your father name: ");
        // student2.FatherName=Console.ReadLine();
        // Console.Write("Enter your date of birth: ");
        // student2.DOB=DateOnly.Parse(Console.ReadLine());
        // Console.Write("Enter your gender: ");
        // student2.StudentGender=Console.ReadLine();
        // Console.Write("Enter your mailID: ");
        // student2.MailId=Console.ReadLine();
        // Console.Write("Enter your physics mark: ");
        // student2.PhysicsMark=Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter your chemistry mark: ");
        // student2.ChemistryMark=Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter your maths mark: ");
        // student2.MathsMark=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Details entered successfully: ");
        // studentList.Add(student2);

        // StudentDetails student3=new StudentDetails();
        // Console.Write("Enter your name: ");
        // student3.StudentName=Console.ReadLine();
        // Console.Write("Enter your father name: ");
        // student3.FatherName=Console.ReadLine();
        // Console.Write("Enter your date of birth: ");
        // student3.DOB=DateOnly.Parse(Console.ReadLine());
        // Console.Write("Enter your gender: ");
        // student3.StudentGender=Console.ReadLine();
        // Console.Write("Enter your mailID: ");
        // student3.MailId=Console.ReadLine();
        // Console.Write("Enter your physics mark: ");
        // student3.PhysicsMark=Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter your chemistry mark: ");
        // student3.ChemistryMark=Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter your maths mark: ");
        // student3.MathsMark=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Details entered successfully: ");
        // studentList.Add(student3);

        // System.Console.WriteLine("Details of Student 1");
        // System.Console.WriteLine($"Student name     : {student1.StudentName}");
        // System.Console.WriteLine($"Father name      : {student1.FatherName}");
        // System.Console.WriteLine($"DOB              : {student1.DOB}");
        // System.Console.WriteLine($"Gender           : {student1.StudentGender}");
        // System.Console.WriteLine($"MailID           : {student1.MailId}");
        // System.Console.WriteLine($"Physics mark     : {student1.PhysicsMark}");
        // System.Console.WriteLine($"Chemistry mark   : {student1.ChemistryMark}");
        // System.Console.WriteLine($"Maths mark       : {student1.MathsMark}");

        // System.Console.WriteLine("Details of Student 2");
        // System.Console.WriteLine($"Student name     : {student2.StudentName}");
        // System.Console.WriteLine($"Father name      : {student2.FatherName}");
        // System.Console.WriteLine($"DOB              : {student2.DOB}");
        // System.Console.WriteLine($"Gender           : {student2.StudentGender}");
        // System.Console.WriteLine($"MailID           : {student2.MailId}");
        // System.Console.WriteLine($"Physics mark     : {student2.PhysicsMark}");
        // System.Console.WriteLine($"Chemistry mark   : {student2.ChemistryMark}");
        // System.Console.WriteLine($"Maths mark       : {student2.MathsMark}");

        // System.Console.WriteLine("Details of Student 3");
        // System.Console.WriteLine($"Student name     : {student3.StudentName}");
        // System.Console.WriteLine($"Father name      : {student3.FatherName}");
        // System.Console.WriteLine($"DOB              : {student3.DOB}");
        // System.Console.WriteLine($"Gender           : {student3.StudentGender}");
        // System.Console.WriteLine($"MailID           : {student3.MailId}");
        // System.Console.WriteLine($"Physics mark     : {student3.PhysicsMark}");
        // System.Console.WriteLine($"Chemistry mark   : {student3.ChemistryMark}");
        // System.Console.WriteLine($"Maths mark       : {student3.MathsMark}");

       
        
    }
}
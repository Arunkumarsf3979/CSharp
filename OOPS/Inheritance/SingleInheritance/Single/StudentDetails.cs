using System;
namespace SingleInheritance
{
    public enum Year{Default,I,II,III}
    public enum Department{Department,ECE,EEE}
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentID=1000;
        public string StudentID{get;}
        public Department Department { get; set; }
        public Year Year { get; set; }
        public StudentDetails(string aID,string name,string fatherName,Gender gender,DateTime dob,Department department,Year year):base(aID,name,fatherName,gender,dob)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Department=department;
            Year=year;
            
        }
        public void ShowStudent()
        {
            Console.WriteLine("StudentID      :"+StudentID);
            Console.WriteLine("Department     :"+Department);
            Console.WriteLine("Year           :"+Year);
            ShowDetails();
        }
        

    }
}
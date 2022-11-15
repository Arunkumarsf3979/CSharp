using System;
namespace Question1
{
    public class Teacher:PersonalInfo
    {
        // Properties: TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining
// Methods: Update, Show
        private static int s_teacherID=1000;
        public string TeacherID { get;}
        public string Department { get; set; }  
        public string Subject { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public Teacher(string name,string fatherName,string phone,string mail,Gender gender,string department,string subject,string qualification,int yearOfExperience,DateTime dateOfJOining):base(name,fatherName,phone,mail,gender)
        {
            s_teacherID++;
            TeacherID="TID"+s_teacherID;
            Department=department;
            Subject=subject;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJOining;
        }
        public void Update(string name,string fatherName,string phone,string mail,Gender gender,string department,string subject,string qualification,int yearOfExperience,DateTime dateOfJOining)
        {
            Department=department;
            Subject=subject;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJOining;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            Gender=gender;
        }
        public void ShowInfo()
        {
            ShowPersonalInfo();
            System.Console.WriteLine("TeacherID   :"+TeacherID);
            System.Console.WriteLine("Department :"+Department);
            System.Console.WriteLine("Subject :"+Subject);
            System.Console.WriteLine("Qualification :"+Qualification);
            System.Console.WriteLine("YearOfExperience :"+YearOfExperience);
            System.Console.WriteLine("DateOfJoining :"+DateOfJoining);
        }
    }
}
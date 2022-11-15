using System;
namespace Question3
{
    public enum Gender{Default,Male,Female,Others}
    public class PersonalInfo:Attendance
    {
        // Properties: Name, FatherName,Phone,Mail, dob,Gender 
        // Constructor to assign values
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public Gender Gender { get; set; }
        public PersonalInfo(string name,string phone,string mail,Gender gender,int NoOfHoursWorked)
        {
            Name=name;
            Phone=phone;
            Mail=mail;
            Gender=gender;
        }
        public void ShowPersonalInfo()
        {
            Console.WriteLine("Name         :"+Name);
            // Console.WriteLine("Father name  :"+FatherName);
            Console.WriteLine("Phone        :"+Phone);
            Console.WriteLine("Mail         :"+Mail);
            Console.WriteLine("Gender       :"+Gender);
        }
    }
}
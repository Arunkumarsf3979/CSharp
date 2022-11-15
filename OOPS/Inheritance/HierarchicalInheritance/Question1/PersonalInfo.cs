using System;
namespace Question1
{
    public enum Gender{Default,Male,Female,Others}
    public class PersonalInfo
    {
        // Properties: Name, FatherName,Phone,Mail, dob,Gender 
        // Constructor to assign values
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public Gender Gender { get; set; }
        public PersonalInfo(string name,string fatherName,string phone,string mail,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            Gender=gender;
        }
        public void ShowPersonalInfo()
        {
            Console.WriteLine("Name         :"+Name);
            Console.WriteLine("Father name  :"+FatherName);
            Console.WriteLine("Phone        :"+Phone);
            Console.WriteLine("Mail         :"+Mail);
            Console.WriteLine("Gender       :"+Gender);
        }
    }
}
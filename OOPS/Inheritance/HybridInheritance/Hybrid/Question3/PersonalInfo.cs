using System;
namespace Question3
{
    public enum Gender{Default,Male,Female,Others}
    public class PersonalInfo:FamilyInfo
    {
        // Properties: Name, FatherName,Phone,Mail, dob,Gender 
        // Constructor to assign values
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
         public string PermanantAddress { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public Gender Gender { get; set; }
        public PersonalInfo(string name,string fatherName,string motherName,string address,string phone,string mail,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            MotherName=motherName;
            PermanantAddress=address;
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
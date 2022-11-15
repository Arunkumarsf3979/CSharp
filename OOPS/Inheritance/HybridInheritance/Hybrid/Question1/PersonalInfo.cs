using System;
namespace Question1
{
    public enum Gender{Default,Male,Female,Others}
    public class PersonalInfo
    {
        // Properties: Name, FatherName,Phone,Mail, dob,Gender 
        // Constructor to assign values
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
         public string PermanantAddress { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public Gender Gender { get; set; }
        public PersonalInfo(string RegistrationNumber,string name,string fatherName,string motherName,string address,string phone,string mail,Gender gender)
        {
            Name=name;
            this.RegistrationNumber=RegistrationNumber;
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
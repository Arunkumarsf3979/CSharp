using System;
namespace HybridInheritance
{
    public enum Gender{Default,Male,Female,Others}
    public class PersonalDetails
    {
        private static int s_aid=1000;
        public string AID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public PersonalDetails(string name,string fatherName,Gender gender,DateTime dob)
        {
            s_aid++;
            AID="AD"+s_aid;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            DOB=dob;
        }
        public PersonalDetails(string aID,string name,string fatherName,Gender gender,DateTime dob)
        {
            AID=aID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            DOB=dob;
        }
        
        public void ShowDetails()
        {
            Console.Write("AID: {0}\nName: {1}\nFatherName: {2}\nGender: {3}\nDateOfBirth: {4}\n",AID,Name,FatherName,Gender,DOB.ToString("dd/MM/yyyy"));
        }
    }
}
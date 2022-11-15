using System;
namespace ReadWriteCSV
{
    public enum Gender{Default,Male,Female,Others}
    public class Student
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public Student(string name,string fatherName,Gender gender,DateTime dob)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            DOB=dob;
        }
        public Student(){}
    }
}
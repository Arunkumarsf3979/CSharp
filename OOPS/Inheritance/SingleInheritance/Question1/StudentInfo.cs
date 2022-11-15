using System;
namespace Question1
{
    public enum AcademicYear{Default,I,II,III}
    public class StudentInfo:PersonalInfo
    {
// Propeties: RegisterNumber, Standard, Branch, AcadamicYear
// 	Method: UpdateInfo, ShowInfo

        public int RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public AcademicYear AcademicYear  { get; set; }

        public StudentInfo(string name,string fatherName,string phone,string mail,Gender gender,int registerNumber,string standard,string branch,AcademicYear academicYear):base(name,fatherName,phone,mail,gender)
        {
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Register Number         :"+RegisterNumber);
            Console.WriteLine("Standard                :"+Standard);
            Console.WriteLine("Branch                  :"+Branch);
            Console.WriteLine("Academic Year           :"+AcademicYear);
            ShowPersonalInfo();
        }
        public void UpdateInfo(string name,string fatherName,string phone,string mail,Gender gender,string standard,string branch,AcademicYear academicYear)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            Gender=gender;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }

    }
}
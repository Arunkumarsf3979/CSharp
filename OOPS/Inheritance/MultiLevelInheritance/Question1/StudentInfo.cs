using System;
namespace Question1
{
    public class StudentInfo:PersonalInfo
    {
        
// Class StudentInfo: inherits PersonalInfo
// Propeties: RegisterNumber, Standard, Branch, AcadamicYear
// 	Method: UpdateInfo, ShowInfo

    public int RegisterNumber { get; set; }
    public string Standard { get; set; }
    public string Branch { get; set; }
    public DateTime AcadamicYear { get; set; }

    public StudentInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,int registerNumber,string standard,string branch,DateTime acadamicYear):base(name,fatherName,phone,mail,dob,gender)
    {
        RegisterNumber=registerNumber;
        Standard=standard;
        Branch=branch;
        AcadamicYear=acadamicYear;
    }
    public void UpdateInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,int registerNumber,string standard,string branch,DateTime acadamicYear)
    {
        Name=name;
        FatherName=fatherName;
        Phone=phone;
        Mail=mail;
        Gender=gender;
        DOB=dob;
        RegisterNumber=registerNumber;
        Standard=standard;
        Branch=branch;
        AcadamicYear=acadamicYear;
    }
    public void ShowInfo()
    {
        ShowPersonalInfo();
        System.Console.WriteLine("Register Number :"+RegisterNumber);
        System.Console.WriteLine("Standard  :"+Standard);
        System.Console.WriteLine("Branch  :"+Branch);
        System.Console.WriteLine("Acadamic Year :"+AcadamicYear);
    }
    }
}
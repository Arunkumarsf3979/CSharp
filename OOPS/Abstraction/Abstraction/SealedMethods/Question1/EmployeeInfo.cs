using System;
namespace Question1
{
//     Class EmployeeInfo: Inherit FamilyInfo
// Properties: EmployeeID, DateOfJoining
// Method: override Update and override DisplayInfo

    public class EmployeeInfo:FamilyInfo
    {
        private static int s_employeeID=1000; 
        public string EmployeeID { get; set; }
        public DateTime DateOfJoining { get; set; }
        
        public EmployeeInfo(string name,Gender gender,DateTime dob,long phone,long mobile,MaritalDetails maritalDetails,string fatherName,string motherName,int noOfSibilings,string nativePlace,DateTime date):base(name,gender,dob,phone,mobile,maritalDetails,fatherName,motherName,noOfSibilings,nativePlace)
        {
            DateOfJoining=date;
        }
        public override void Update(string name)
        {
            Name=name;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Fathername      :"+FatherName);
            System.Console.WriteLine("MotherName      :"+MotherName);
            System.Console.WriteLine("Noof sibilings  :"+NoOfSibilings);
        }
        
    }
}
using System;
namespace Question1
{
//     Class RegisterPerson inherits personalinfo, ShowData, FamilyInfo 
// Properties: RegistrationNumber(Auto), DateOfRegistration, 
// Methods: UpdateInfo, ShowInfo
    public class RegisterPerson:PersonalInfo,FamilyInfo,ShowData
    {
        public static int s_registrationNumber=1000;
        public string RegistrationNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string FatherName{get;set;}
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSibilings { get; set; }
        public RegisterPerson(string name,Gender gender,DateTime dob,long phone,long mobile,MaritalDetails maritalDetails,string fatherName,string motherName,string houseAddress,int noOfSibiings,DateTime dateOfRegistration):base(name,gender,dob,phone,mobile,maritalDetails)
        {
            s_registrationNumber++;
            RegistrationNumber="RID"+s_registrationNumber;
            DateOfRegistration=dateOfRegistration;
            FatherName=fatherName;
            MotherName=motherName;
            HouseAddress=houseAddress;
            NoOfSibilings=noOfSibiings;
        }
        public void UpdateInfo(string name,Gender gender,DateTime dob,long phone,long mobile,MaritalDetails maritalDetails,string fatherName,string motherName,string houseAddress,int noOfSibiings,DateTime dateOfRegistration)
        {
            DateOfRegistration=dateOfRegistration;
            FatherName=fatherName;
            MotherName=motherName;
            HouseAddress=houseAddress;
            NoOfSibilings=noOfSibiings;
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            Mobile=mobile;
            MaritalDetails=maritalDetails;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("FatherName     :"+FatherName);
            System.Console.WriteLine("MotherName     :"+MotherName);
            System.Console.WriteLine("HouseAddress   :"+HouseAddress);
            System.Console.WriteLine("NoOfSibilings  :"+NoOfSibilings);
        }
        
        
        
    }
}
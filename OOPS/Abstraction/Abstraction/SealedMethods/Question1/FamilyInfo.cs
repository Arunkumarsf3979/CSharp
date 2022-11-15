using System;
namespace Question1
{
    
// Class FamilyInfo: Inherit PersonalInfo 
// Properties: FatherName, MotherName, NoOfSiblings, NativePlace
// Method: Sealed override Update, DisplayInfo

    public class FamilyInfo:PersonalInfo
    {
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int NoOfSibilings { get; set; }
        public string NativePlace { get; set; }
        
        public FamilyInfo(string name,Gender gender,DateTime dob,long phone,long mobile,MaritalDetails maritalDetails,string fatherName,string motherName,int noOfSibilings,string nativePlace):base(name,gender,dob,phone,mobile,maritalDetails)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            Mobile=mobile;
            MaritalDetails=maritalDetails;
        }
        public sealed override void Update(string name)
        {
            Name=name;
        }
        public sealed override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Fathername      :"+FatherName);
            System.Console.WriteLine("MotherName      :"+MotherName);
            System.Console.WriteLine("Noof sibilings  :"+NoOfSibilings);
        }
    }
}
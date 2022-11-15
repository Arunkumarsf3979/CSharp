using System;
namespace Question1
{
//     Class Personalnfo inherit ShowData
// Properties: Name, Gender,DOB, phone, mobile, Marital details – Married/single
// Method: Show Info
    public enum Gender{Default,Male,Female,Others}
    public enum MaritalDetails{Default,Married,Single}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        public long Mobile { get; set; }
        public MaritalDetails  MaritalDetails { get; set; }
        public PersonalInfo(string name,Gender gender,DateTime dob,long phone,long mobile,MaritalDetails maritalDetails)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            Mobile=mobile;
            MaritalDetails=maritalDetails;
        }
        public virtual void ShowInfo()
        {
            System.Console.WriteLine("Name                :"+Name);
            System.Console.WriteLine("Gender              :"+Gender);
            System.Console.WriteLine("DOB                 :"+DOB);
            System.Console.WriteLine("Phone               :"+Phone);
            System.Console.WriteLine("Mobile              :"+Mobile);
            System.Console.WriteLine("MaritalDetails      :"+MaritalDetails);
        }
        public virtual void Update(string name)
        {
            Name=name;
        }
                
        
        
        
        
        
        
    }
}
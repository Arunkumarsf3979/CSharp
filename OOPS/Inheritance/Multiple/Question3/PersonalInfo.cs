using System;
namespace Question3
{
//     Class PersonalInfo:
// Properties: Name, Gender,DOB, phone, mobile, PAN number
    public enum Gender{Default,Male,Female}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        public long Mobile { get; set; }
        public string PanNumber { get; set; }
        
        
        
        
        
        
        
    }
}
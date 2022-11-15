namespace Question1
{
//     Class PersonalInfo:
// Properties: Name, FatherName,MobileNumber,Gender
// Methods: Abstract  -> Display.
    public enum Gender{Default,Male,Female,Others}
    public abstract class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }
        public Gender Gender{get;set;}
        public PersonalInfo(string name,string fatherName,long mobile,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Gender=gender;
        }
        public void ShowPersonalInfo()
        {
            System.Console.WriteLine("Name       :"+Name);
            System.Console.WriteLine("FatherName :"+FatherName);
            System.Console.WriteLine("Mobile     :"+Mobile);
            System.Console.WriteLine("Gender     :"+Gender);
        }
        public abstract void Display();
        
        
        
    }
}
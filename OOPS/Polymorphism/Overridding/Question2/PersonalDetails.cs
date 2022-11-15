namespace Question2
{
    // Class PersonDetails
// Property: Name, FatherName,Gender,Qualification
    public enum Gender {Default,Male,Female,Others}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public string Qualification { get; set; }
        public PersonalDetails(string name,string fatherName,Gender gender,string qualification)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Qualification=qualification;
        }
        
    }
}
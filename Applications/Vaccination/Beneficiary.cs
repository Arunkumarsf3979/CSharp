namespace Vaccination
{
    public enum Gender{Default,Male,Female,Others}
    public class Beneficiary
    {
        private static int s_registrationNumber=1000;
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string MobileNumber { get; set; }
        public string City { get; set; }
        public int Age{get;set;}

        public string RegistrationNumber { get;}
        public Beneficiary(string name,Gender gender,string mobileNumber,string city,int age)
        {
            s_registrationNumber++;
            RegistrationNumber="BID"+s_registrationNumber;
            Name=name;
            Gender=gender;
            MobileNumber=mobileNumber;
            City=city;
            Age=age;
        }  
    }
}
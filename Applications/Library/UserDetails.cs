namespace Library
{
    public enum Gender{Default,Male,Female,Transgender}
    public enum Department{ECE,EEE,CSE}
    public class UserDetails
    {
        private static int s_RegistrationId=3000;
        public string UserName{get;set;}
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public string MobileNumber { get; set; }
        public string MailId { get; set; }
        public string RegistrationID{get;}

        public UserDetails(string name,Gender gender,Department department,string mobile,string mailId)
        {
            s_RegistrationId++;
            RegistrationID="SF"+s_RegistrationId;
            UserName=name;
            Gender=gender;
            Department=department;
            MobileNumber=mobile;
            MailId=mailId;
        }
    }
}
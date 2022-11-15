namespace Question3
{
//     Class RegisterApplication inherits TheoryExam Marks
// Properties: RegisterNumber, Experience in Months, FieldOfIntrest
// Methods: Show Details, Update Details.

    public class RegisterApplication:UGInfo
    {
        public string RegisterNumber { get; set; }
        public int ExperienceInMonths { get; set; }
        public string FieldOfInterest { get; set; }
        
        public RegisterApplication(string registerNumber,int experience,string field,string degree,string branch,float[]sem1,float[]sem2,float[]sem3,float[]sem4,string name,string fatherName,string motherName,string address,string phone,string mail,Gender gender):base(degree,branch,sem1,sem2,sem3,sem4,name,fatherName,motherName,address,phone,mail,gender)
        {
            RegisterNumber=registerNumber;
            ExperienceInMonths=experience;
            FieldOfInterest=field;
        }
        public void ShowInfo()
        {
            ShowPersonalInfo();
            MethodEligibility();
        }
        
    }
}
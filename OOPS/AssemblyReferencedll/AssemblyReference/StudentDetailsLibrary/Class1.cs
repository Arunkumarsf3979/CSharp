using System;
/// <summary>
/// Used to process the college admission using this application
/// </summary>
namespace StudentDetailsLibrary
{
    /// <summary>
    /// Used to select a student's gender information
    /// </summary>
    public enum Gender{Default,Male,Female,Transgender}
    /// <summary>
    /// Class <see cref="StudentDetails"/>used to collect student informations
    /// </summary>
    public class StudentDetails
    {
        private static int s_registrationID=3000;//Field
        public string RegistrationId{get;}//Property
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateOnly DOB { get; set; }
        public Gender StudentGender { get; set; }
        public string MailId { get; set; }
        public int PhysicsMark { get; set; }
        public int ChemistryMark { get; set; }
        public int MathsMark { get; set; }

        // public StudentDetails()
        // {
        //     StudentName="Your Name";
        //     FatherName="Your FatherName";
        // }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="fatherName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="gender"></param>
        /// <param name="mailID"></param>
        /// <param name="physics"></param>
        /// <param name="chemistry"></param>
        /// <param name="maths"></param>
        public StudentDetails(string studentName,string fatherName,DateOnly dateOfBirth,Gender gender,string mailID,int physics,int chemistry,int maths)
        {
            StudentName=studentName;
            FatherName=fatherName;
            DOB=dateOfBirth;
            StudentGender=gender;
            MailId=mailID;
            PhysicsMark=physics;
            ChemistryMark=chemistry;
            MathsMark=maths;
            s_registrationID++;
            RegistrationId="SF"+s_registrationID;
        }
        // ~StudentDetails()//destructor
        // {
        //     Console.Write();
        // }
        /// <summary>
        /// Method check eligibilty get cutoff values as a parameter and checks the eligibility of student
        /// </summary>
        /// <param name="cutoff"></param>Used to provide cutoff value for eligibility
        /// <returns></returns>
        public bool Eligibility(double cutoff)
        {
            double average=(PhysicsMark+MathsMark+ChemistryMark)/3;
            if(average>cutoff)
            {
                return true;
            }
            else{
                return false;
            }
        }
        
    }
}
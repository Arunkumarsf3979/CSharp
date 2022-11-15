using System;
namespace CollegeAdmissionUpdate
{
    public enum Gender{Default,Male,Female,Transgender}
    public class StudentDetails
    {
        private static int s_StudentID=3000;
        public string  StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public float Physics { get; set; }
        public float Chemistry{get; set;}
        public float Maths { get; set; }
        public string StudentID { get; set; }
        public StudentDetails(string studentName,string fatherName,DateTime dob,Gender gender,float physics,float chemistry,float maths)
        {
            s_StudentID++;
            StudentID="SF"+s_StudentID;
            StudentName=studentName;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public bool CheckEligibility(float cutoff)
        {
            if(cutoff<(Physics+Chemistry+Maths)/3)
            {
                return true;
            }
            else{
                return false;
            }
        }
        // string studentName,string fatherName,DateTime dob,Gender gender,float physics,float chemistry,float maths
        public StudentDetails(string data)
        {
            string []values=data.Split(',');
            s_StudentID=int.Parse(values[0].Remove(0,2));
            StudentID=values[0];
            StudentName=values[1];
            FatherName=values[2];
            DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            Gender=Enum.Parse<Gender>(values[4],true);
            Physics=int.Parse(values[5]);
            Chemistry=int.Parse(values[6]);
            Maths=int.Parse(values[7]);
        }
    }
}
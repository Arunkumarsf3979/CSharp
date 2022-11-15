using System;
namespace Question1
{
//     Class TheoryExamMarks : Inhertis PersonalInfo
// Properties: Sem1[], Sem2[], Sem3[], Sem4[] Marks – 6 marks in each sem.
    public class TheoryExamMarks:PersonalInfo
    {
        public float[] Sem1 { get; set; }
        public float[] Sem2 { get; set; }
        public float[] Sem3 { get; set; }
        public float[] Sem4 { get; set; }
        public TheoryExamMarks(string RegistrationNumber,string name,string fatherName,string motherName,string address,string phone,string mail,Gender gender,float[] sem1,float[] sem2,float[] sem3,float[] sem4):base(RegistrationNumber,name,fatherName,motherName,address,phone,mail,gender)
        {
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
        
    }
}
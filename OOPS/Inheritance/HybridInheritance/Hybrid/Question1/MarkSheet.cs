using System;
namespace Question1
{
//     Class Marksheet: inherit TheoryExammarks, ICalculate
// Properties: MarksheetNumber, DateOfIssue, Total, Percentage
// Methods : SHowUGMarkSHeet

    public class MarkSheet:TheoryExamMarks,ICalculate
    {
        public string MarkSheetNumber { get; set; }
        public DateTime DateOfIssus { get; set; }
        public float Total{get;set;}
        public float Percentage{get;set;}
        public float ProjectMark{get;set;}
        public MarkSheet(string RegistrationNumber,string name,string fatherName,string motherName,string address,string phone,string mail,Gender gender,string markSheetNumber,float[] sem1,float[] sem2,float[] sem3,float[] sem4,float project):base(RegistrationNumber,name,fatherName,motherName,address,phone,mail,gender,sem1,sem2,sem3,sem4)
        {
            this.RegistrationNumber=RegistrationNumber;
            Name=name;
            FatherName=fatherName;
            MotherName=motherName;
            PermanantAddress=address;
            Phone=phone;
            Mail=mail;
            Gender=gender;
            MarkSheetNumber=markSheetNumber;
            ProjectMark=project;
        }
        public void SHowUGMarkSHeet()
        {
            System.Console.WriteLine("MarksheetNumber     :"+MarkSheetNumber);
        }
        public void CalculateUG()
        {
            float total=0;
            foreach(float mark in Sem1)
            {
                total+=mark;
            }
            foreach(float mark in Sem2)
            {
                total+=mark;
            }
            foreach(float mark in Sem3)
            {
                total+=mark;
            }
            foreach(float mark in Sem3)
            {
                total+=mark;
            }
            System.Console.WriteLine("Total marks  :"+total);
            System.Console.WriteLine("Percentage   :"+total/24);
        }
        
    }
}
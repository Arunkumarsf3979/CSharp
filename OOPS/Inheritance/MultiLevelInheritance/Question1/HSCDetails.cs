using System;
namespace Question1
{
    public class HSCDetails:StudentInfo
    {
        // Properties: HSCMarksheetNumber, Physics, Chemistry, Maths, Total, Percentage marks
	// Methods: Calculate – Total and percentage, Show Marksheet.
        public int HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double PercentageMarks { get; set; }
        public HSCDetails(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,int registerNumber,string standard,string branch,DateTime acadamicYear,int hscMarksheetNumber,int physics,int chemistry,int maths):base(name,fatherName,phone,mail,dob,gender,registerNumber,standard,branch,acadamicYear)
        {
            HSCMarksheetNumber=hscMarksheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        
        }
        public void ShowMarksheet()
        {
            System.Console.WriteLine("Physics :"+Physics);
            System.Console.WriteLine("chemsitry :"+Chemistry);
            System.Console.WriteLine("Maths :"+Maths);
            System.Console.WriteLine("Total  :"+Total);
            System.Console.WriteLine("Percentage :"+PercentageMarks);
        }
        public void TotalMarks()
        {
            Total=Physics+Chemistry+Maths;
        }
        public void Percentage()
        {
            PercentageMarks=Total/3;
        }
    }
}
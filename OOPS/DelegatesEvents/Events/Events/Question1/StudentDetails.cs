using System;
namespace Question1
{
    public class StudentDetails
    {
        private static int s_studentID=1000;
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double  Maths { get; set; }
        public double  Percentage { get; set; }
        public StudentDetails(double Physics,double Chemistry,double Maths)
        {
            this.Physics=Physics;
            this.Chemistry=Chemistry;
            this.Maths=Maths;
        }
        public void GetDetails()
        {
            System.Console.WriteLine("Enter your name");
            Name=Console.ReadLine();
            System.Console.WriteLine("Enter your Father name");
            FatherName=Console.ReadLine();
        }
        public void Calculate()
        {
            Console.WriteLine("Percentage  "+(Physics+Chemistry+Maths)/3);
        }
        
        
        
        
        
    }
}
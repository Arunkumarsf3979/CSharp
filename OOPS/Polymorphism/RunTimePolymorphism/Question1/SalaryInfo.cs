namespace Question1
{
//     Class SalaryInfo inherits: EmployeeInfo
// Field, Properties: NumberOfDaysWorked
// Method: Overridden -> Display -> Display Employee PersonalInfo and Display salary based on number of working days * 500.

    public class SalaryInfo:EmployeeInfo
    {
        public int NoOfDaysWorked { get; set; }
        public SalaryInfo(string name,string fatherName,long mobile,Gender gender,int noOfDaysWorked):base(name,fatherName,mobile,gender)
        {
            NoOfDaysWorked=noOfDaysWorked;
        }
        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("Salary    :"+(500*NoOfDaysWorked));
        }
        
        
    }
}
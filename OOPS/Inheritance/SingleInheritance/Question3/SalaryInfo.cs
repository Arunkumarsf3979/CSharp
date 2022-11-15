namespace Question3
{
//     Class SalaryInfo
// Properties: SalaryOfTheMonth, Month
// Method: Calculate Salary-> for given month , DisplaySalary - > for a given month 

    public class SalaryInfo:Attendance
    {
        public int SalaryOfTheMonth { get; set; }
        public string Month{get;set;}
        public SalaryInfo(int salary,string month,DateTime date,int NoOfHoursWorked):base(date,NoOfHoursWorked)
        {
            SalaryOfTheMonth=salary;
            Month=month;
            this.NoOfHoursWorked=NoOfHoursWorked;
        }
        public void CalculateSalary()
        {
            System.Console.WriteLine("Your salary is :"+SalaryOfTheMonth);
        }
        public void DisplaySalary()
        {
             System.Console.WriteLine("Your salary is :"+SalaryOfTheMonth);
        }
        
    }
}
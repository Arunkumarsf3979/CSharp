using System;
namespace Question2
{
    public class PermanentEmployee:SalaryInfo
    {
        // Class Permanent Employee: inherit salary info
// Properties: EmployeeID, Employee Type, DA=0.2% of basic, HRA= 0.18% of basic, PF – 0.1 % basic, Total Salary
// Method: Calculate Total Salary – Basic +DA+HRA-PF, Show salary
        private static int s_employeeID=1000;
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public double DA=0.2;
        public double HRA=0.18;
        public double PF=0.1;
        public double TotalSalary { get; set; }
        public PermanentEmployee(int basicSalary,string month,string employeeType):base(basicSalary,month)
        {
            s_employeeID++;
            EmployeeID="PID"+s_employeeID;
            EmployeeType=employeeType;
        }
        public void CalculateTotalSalary()
        {
            TotalSalary=BasicSalary+(DA+HRA+PF)*BasicSalary;
        }
        public void ShowSalary()
        {
            Console.WriteLine("Your salary is "+TotalSalary);
        }
    }
}
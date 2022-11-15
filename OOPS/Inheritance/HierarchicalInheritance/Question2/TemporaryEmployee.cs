using System;
namespace Question2
{
    public class TemporaryEmployee:SalaryInfo
    {
        // Properties: EmployeeID, Employee Type, DA=0.15% of basic, HRA= 0.13% of basic, Total Salary
// Method: Calculate Total Salary – Basic +DA+HRA-PF, Show salary
        private static int s_employeeID=1000;
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public double DA=0.15;
        public double HRA=0.13;
        public double PF=0.1;
        public double TotalSalary { get; set; }
        public TemporaryEmployee(int basicSalary,string month,string employeeType):base(basicSalary,month)
        {
            s_employeeID++;
            EmployeeID="TID"+s_employeeID;
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
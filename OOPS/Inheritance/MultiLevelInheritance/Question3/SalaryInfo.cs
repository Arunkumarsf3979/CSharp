using System;
using System.Collections.Generic;
namespace Question3
{
//     Class SalaryInfo inherits personal info
// Properties: SalaryOfTheMonth, Month,  List<Attendance>, 
// Method: Log Attendance, Calculate Salary-> for given month , DisplaySalary - > for a given month 

    public class SalaryInfo:PersonalInfo
    {
        public int SalaryOfTheMonthe { get; set; }
        public string Month { get; set; }
        public int Salary { get; set; }
        public SalaryInfo(int salaryOfMonth,string month,string name,string phone,string mail,Gender gender,int NoOfHoursWorked):base(name,phone,mail,gender,NoOfHoursWorked)
        {
            SalaryOfTheMonthe=salaryOfMonth;
            Month=month;
        }
        public void CalculateSalary()
        {
            Salary=NoOfHoursWorked*SalaryOfTheMonthe;
        }
        public void DisplaySalary()
        {
            System.Console.WriteLine("Your Salary is "+Salary);
        }
    }
}
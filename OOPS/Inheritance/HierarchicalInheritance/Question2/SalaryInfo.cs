using System;
namespace Question2
{
    public class SalaryInfo
    {
        // Properties: BasicSalary, Month
        public int BasicSalary { get; set; }
        public string Month{get;set;}
        public SalaryInfo(int basicSalary,string month)
        {
            BasicSalary=basicSalary;
            Month=month;
        }

    }
}
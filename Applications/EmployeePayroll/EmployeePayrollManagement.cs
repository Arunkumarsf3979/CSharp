using System;
namespace EmployeePayroll
{
    public enum gender{Default,Male,Female}
    public class EmployeePayrollManagement
    {
        private static int s_employeeID=1000;
        public string EmployeeName { get; set; }
        public string Role { get; set; }
        public string WorkLocation { get; set; }
        public string TeamName { get; set; }
        public DateOnly DateOfJoining { get; set; }
        public int NumberOfWorkingDays { get; set; }
        public double NumberOfLeaveTaken { get; set; }
        public gender Gender{get;set;}
        public string EmployeeID { get;  }

        public  double SalaryCalculation(int amountPerDay)
        {
            double salary=NumberOfWorkingDays-NumberOfLeaveTaken;
            return salary*amountPerDay;
        }
        public EmployeePayrollManagement(string name,string role,string location,string teamName,DateOnly doj,int workingDays,double leave,gender gender)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            EmployeeName=name;
            Role=role;
            WorkLocation=location;
            TeamName=teamName;
            DateOfJoining=doj;
            NumberOfWorkingDays=workingDays;
            NumberOfLeaveTaken=leave;
            Gender=gender;
        }
    }
}
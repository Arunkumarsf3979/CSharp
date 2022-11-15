using System;
namespace Question3
{
//     Class Employee
// Properties: EmployeeID, EmployeeName, Gender, NumberOfDaysWorked
// Method: DisplaySalary
    public enum Gender{Default,Male,Female}
    public class Employee
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get{s_employeeID++;return "EMP"+s_employeeID;}}
        public string EmployeeName { get; set; }
        public Gender Gender { get; set; }
        public int NumberOfDaysWorked { get; set; }
        public virtual void DisplaySalary()
        {
            System.Console.WriteLine("EmployeeID   :"+EmployeeID);
            System.Console.WriteLine("Employee Name:"+EmployeeName);
            System.Console.WriteLine("Gender       :"+Gender);
            System.Console.WriteLine("NoOfDaysWorked :"+NumberOfDaysWorked);
        }
        
        
        
    }
}
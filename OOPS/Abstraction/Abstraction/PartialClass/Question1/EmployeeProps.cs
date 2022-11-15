using System;
namespace Question1
{
    // •	Inside that create a partial class Employee info and provide 
    // properties -  EmployeeID,Name,Gender,DOB, Mobile
    public enum Gender{Default,Male,Female,Others}
    public partial class Employee
    {
        private static int s_employeeID=100;
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public Gender Gender{ get; set; }
        public DateTime DOB { get; set; }
        public long Mobile { get; set; }
        
        
    }
}
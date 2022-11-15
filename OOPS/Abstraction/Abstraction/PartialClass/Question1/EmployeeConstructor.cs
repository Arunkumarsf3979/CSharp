using System;
namespace Question1
{
    // •	Inside that create a partial class Employee info and provide Constructor
    public partial class Employee
    {
        public Employee(string name,Gender gender,DateTime dob,long mobile)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
        }
    }
}
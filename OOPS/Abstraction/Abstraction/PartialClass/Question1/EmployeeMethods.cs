using System;
namespace Question1
{
    public partial class Employee
    {
        public void Update(string name,Gender gender,DateTime dob,long mobile)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
        }
        public void Display()
        {
            System.Console.WriteLine("EmployeeID        :"+EmployeeID);
            System.Console.WriteLine("Name              :"+Name);
            System.Console.WriteLine("Gender            :"+Gender);
            System.Console.WriteLine("DOB               :"+DOB);
            System.Console.WriteLine("Mobile            :"+Mobile);
        }
    }
}
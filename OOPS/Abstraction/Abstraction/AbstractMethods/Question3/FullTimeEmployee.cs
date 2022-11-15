using System;
namespace Question3
{
    
// Class fulltimeEmployee inherit employee
// Overridden method : Displaysalary -> numberofdaysworked * 600

    public class FullTimeEmployee:Employee
    {
        public FullTimeEmployee(string Name,Gender gender,int NoOfDaysWorked)
        {
            
            EmployeeName=Name;
            Gender=gender;
            NumberOfDaysWorked=NoOfDaysWorked;
        }
        public override void DisplaySalary()
        {
            base.DisplaySalary();
            System.Console.WriteLine("salary    :"+(NumberOfDaysWorked*600));
        }
        
    }
}
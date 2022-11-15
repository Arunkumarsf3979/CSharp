namespace Question3
{
    public class PartTimeEmployee:Employee
    {
        public PartTimeEmployee(string Name,Gender gender,int NoOfDaysWorked)
        {
            EmployeeName=Name;
            Gender=gender;
            NumberOfDaysWorked=NoOfDaysWorked;
        }
        public override void DisplaySalary()
        {
            base.DisplaySalary();
            System.Console.WriteLine("salary    :"+(NumberOfDaysWorked*400));
        }
    }
}
namespace Question2
{
//     Class Syncfusion inherits FreeLancer
// Field : EmployeeID
// Property: EmployeeID, Worklocation
// Method: Overridden CalculateSalary method that calculate salary by 
// NoOfWorkingDays*500 and Overridden display method that display employees details

    public class Syncfusion:FreeLancer
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get; set; }
        public string WorkLocation { get; set; }
        public Syncfusion(string name,string fatherName,Gender gender,string qualification,string role,int noOfWorkingDays,string workLocation):base(name,fatherName,gender,qualification,role,noOfWorkingDays)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            WorkLocation=workLocation;
        }
        public override void CalculateSalary()
        {
            // base.CalculateSalary();
            SalaryAmount=NoOfWorkingDays*500;
        }
        public override void Display()
        {
            // base.Display();
            System.Console.WriteLine("EmpID        :"+EmployeeID);
            System.Console.WriteLine("WorkLocation :" +WorkLocation);
        }
    }
}
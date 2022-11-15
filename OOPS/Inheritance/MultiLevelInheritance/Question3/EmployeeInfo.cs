namespace Question3
{

// Class EmployeeInfo: Inherits SalaryInfo
// Properties: EmployeeID, Branch, floor.
// Method: UpdateDetails, ShowDetails.

    public class EmployeeInfo:SalaryInfo
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get; set; }
        public string Branch { get; set; }
        public int  Floor { get; set; }
        public EmployeeInfo(int salaryOfMonth,string month,string name,string phone,string mail,Gender gender,int NoOfHoursWorked,string branch,int floor):base(salaryOfMonth,month,name,phone,mail,gender,NoOfHoursWorked)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Branch=branch;
            Floor=floor;
            this.NoOfHoursWorked=NoOfHoursWorked;
        }
        public void UpdateDetails(string name)
        {
            Name=name;
        }
        public void ShowDetails()
        {
            ShowPersonalInfo();
            System.Console.WriteLine("Branch            :"+Branch);
            System.Console.WriteLine("EmployeeID        :"+EmployeeID);
            System.Console.WriteLine("fLOOR             :"+Floor);
        }
        
        
        
    }
}
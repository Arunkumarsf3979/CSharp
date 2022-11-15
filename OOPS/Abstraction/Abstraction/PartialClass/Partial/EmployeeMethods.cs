namespace Partial
{
    public partial class Employee
    {
        public Employee(int id,string name)
        {
            this.EmpID=id;
            this.Name=name;
        }
        public void DisplayEmpInfo()
        {
            System.Console.WriteLine("Employee Id: "+EmpID);
            System.Console.WriteLine("Name        :"+Name);
        }
        public partial void ShowEmpID()
        {
            System.Console.WriteLine("EmpID   :"+EmpID);
        }
    }
}
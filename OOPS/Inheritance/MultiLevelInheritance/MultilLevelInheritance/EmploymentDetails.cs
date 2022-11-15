using System;
namespace MultiLevelInheritance

{
    public class EmploymentDetails:StudentDetails
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get;}
        public DateTime DateOfJoining { get; set; }
        public EmploymentDetails(string studentID,string aID,string name,string fatherName,Gender gender,DateTime dob,Department department,DateTime dateOfJoining):base(studentID,aID,name,fatherName,gender,dob,department)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            DateOfJoining=dateOfJoining;
        }
        public void ShowEmployeeInfo()
        {
            Console.WriteLine("EmployeeID     :"+EmployeeID);
            Console.WriteLine("DateOfJoining  :"+DateOfJoining);
            ShowDetails();

        }

    }
}
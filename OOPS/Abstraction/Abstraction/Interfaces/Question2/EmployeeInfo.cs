using System;
namespace Question2
{
//     Class EmployeeInfo inherit display interface
// Properties: EmployeeID, Name, FatherName
// Methods: Display

    public class EmployeeInfo:DisplayInfo
    {
        private static int s_employeeID=1000;
        public string EmployeeID{get;set;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public EmployeeInfo(string name,string fatherName)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Name=name;
            FatherName=fatherName;
        }
        public void Display()
        {
            System.Console.WriteLine("EmployeeID      :"+EmployeeID);
            System.Console.WriteLine("Name            :"+Name);
            System.Console.WriteLine("FatherName      :"+FatherName);

        }
        
        
    }
}
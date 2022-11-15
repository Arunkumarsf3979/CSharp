using System;
namespace Question2
{
    public class DepartmentDetails
    {
        // Class DepartmentDetails:
// Properties: DepartmentName, Degree
        public string DepartmentName { get; set; }
        public string Degree { get; set; }
        public DepartmentDetails(string departmentName,string degree)
        {
            DepartmentName=departmentName;
            Degree=degree;
        }
        
    }
}
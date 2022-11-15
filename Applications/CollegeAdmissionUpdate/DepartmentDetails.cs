namespace CollegeAdmissionUpdate
{
    public class DepartmentDetails
    {
        private static int s_DepartmentID=100;
        public string DepartmentName { get; set; }
        public int NumberOfSeats { get; set; }
        public string DepartmentID{get;}
        public DepartmentDetails(string departmentName,int numberOfSeats)
        {
            s_DepartmentID++;
            DepartmentID="DID"+s_DepartmentID;
            DepartmentName=departmentName;
            NumberOfSeats=numberOfSeats;
        }
        public DepartmentDetails(string data)
        {
            string[] values=data.Split(',');
            s_DepartmentID=int.Parse(values[0].Remove(0,3));
            DepartmentID=values[0];
            DepartmentName=values[1];
            NumberOfSeats=int.Parse(values[2]);
        }
    }
}
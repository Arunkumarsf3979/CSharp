namespace Question2
{
    public class RackInfo:DepartmentDetails
    {
        // Class RackInfo:
// Properties: RackNumber, ColumnNumber 
        public int RackNumber { get; set; }
        public int  ColumnNumber { get; set; }
        public RackInfo(string departmentName,string degree,int rackNumber,int columnNumber):base(departmentName,degree)
        {
            RackNumber=rackNumber;
            ColumnNumber=columnNumber;
        }

    }
}
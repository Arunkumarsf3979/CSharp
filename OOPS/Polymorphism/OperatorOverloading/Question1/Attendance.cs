namespace Question1
{
    
// 1.	Create a class named attendance that have total working
//  days in month, number of leaves taken, number of permissions taken.
// a.	Create objects month1, month 2, month3 and calculate the three months 
// total working days, number of leaves taken, and number of permissions taken 
// and calculate the total salary by number of days worked * 500 Rs.  

    public class Attendance
    {
        public int TotalWorkingDays { get; set; }
        public float NumberOfLeaves { get; set; }
        public int NumberOfPermissions { get; set; }
        public Attendance(int totalWorkingDays,float numberOfLeaves,int numberOfPermissions)
        {
            TotalWorkingDays=totalWorkingDays;
            NumberOfLeaves=numberOfLeaves;
            NumberOfPermissions=numberOfPermissions;
        }
        public float TotalSalary()
        {
            return (TotalWorkingDays-NumberOfLeaves)*500;
        }
    }
}
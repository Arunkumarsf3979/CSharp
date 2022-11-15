using System;
namespace Question3
{
    
// Class Attendance:
// Properties: Date, NumberOfHoursWorked.

    public class Attendance
    {
        public DateTime Date { get; set; }
        public int NoOfHoursWorked { get; set; }
        
        public Attendance(DateTime date,int NoOfHoursWorked)
        {
            Date=date;
            this.NoOfHoursWorked=NoOfHoursWorked;
        }
        
        
    }
}
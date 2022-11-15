using System;
namespace Question2
{
    // •	Inside that create a partial class Studentinfo and provide 
    // properties -  StudentID,Name,Gender,DOB, Mobile, Physics, Chemistry, Maths Marks
    public enum Gender{Default,Male,Female,Others}
    public partial class Student
    {
        private static int s_studentID=1000;
        public string StudentID{get{s_studentID++;return "SID"+s_studentID;}}
        public string Name { get; set; }
        public long Mobile{get;set;}
        public Gender Gender{get;set;}
        public DateTime DOB { get; set; }
        public int  Physics { get; set; }
        public int Chemistry { get; set; }
        public int  Maths { get; set; }       
    }
}
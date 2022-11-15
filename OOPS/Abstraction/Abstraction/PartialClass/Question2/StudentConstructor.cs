using System;
namespace Question2
{
    public partial class Student
    {
        public Student(string name,long mobile,Gender gender,DateTime dob,int physics,int chemistry,int maths)
        {
            Name=name;
            Mobile=mobile;
            Gender=gender;
            DOB=dob;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
    }
}
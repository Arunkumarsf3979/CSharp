using System;
namespace MultipleInheritance
{
    public interface IMarkDetails
    {
        double CGPA { get; set; }
        void getMarkDetails(double cGPA);
        
    }
}
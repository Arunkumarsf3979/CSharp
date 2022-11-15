using System;
namespace HybridInheritance
{
    public interface IMarkDetails
    {
        double CGPA { get; set; }
        void getMarkDetails(double cGPA);
        
    }
}
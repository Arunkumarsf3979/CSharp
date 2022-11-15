using System;
namespace AbstractClass
{
    public abstract class Employee
    {
        protected string name;
        public abstract string Name{get;set;}
        public double Amount{get;set;}
        public void Display()
        {
            System.Console.WriteLine(name);
        }
        public abstract void Salary(int dates);
    }
}
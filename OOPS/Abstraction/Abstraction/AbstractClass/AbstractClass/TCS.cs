using System;
namespace AbstractClass
{
    public class TCS:Employee
    {
        public override string Name{get{return name;}set{name=value;}}
        public override void Salary(int dates)
        {
            Display();
            Amount=(double)dates*300;
            Console.WriteLine(Amount);
        }
    }
}
using System;
namespace AbstractClass
{
    public class Syncfusion:Employee
    {
        public override string Name{get{return name;}set{name=value;}}
        public override void Salary(int dates)
        {
            Display();
            Amount=(double)dates*500;
            Console.WriteLine(Amount);
        }
    }
}
using System;
using Outside;
namespace Inside;
class Program{
    public static void Main(string[] args)
    {
        First first=new First();
        Console.WriteLine(first.PublicNumber);
        // System.Console.WriteLine((first.PrivateNumber));
        System.Console.WriteLine(first.PrivateOutNumber);
        // System.Console.WriteLine(first.ProtectedNumber);
        System.Console.WriteLine(first.ProtectedOutNumber);

        Second second=new Second();
        System.Console.WriteLine(second.ProtectedOutNumber1);
        System.Console.WriteLine(second.InternalNumber);
        
        System.Console.WriteLine(first.ProtectedInternalOutNumber);
        

    }
}

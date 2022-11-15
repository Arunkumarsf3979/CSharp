using System;
namespace OperatorOverLoading;
class Program{
    public static void Main(string[] args)
    {
        Box box1=new Box(12,23,34);
        Box box2=new Box(34,3,12);
        System.Console.WriteLine("volume is "+box1.CalculateVolume());
        System.Console.WriteLine("volume is "+box2.CalculateVolume());
        // System.Console.WriteLine(box1+box2);
        Box box3=new Box();
        box3=box1+box2;
        System.Console.WriteLine(box3.CalculateVolume());

    }
}

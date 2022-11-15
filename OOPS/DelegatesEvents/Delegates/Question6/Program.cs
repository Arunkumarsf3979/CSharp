using System;
namespace Question6;
public delegate bool Filter(float percentage);
class Program{
    static bool CheckEligibility(float percentage)
    {
        if(percentage>75)
        {
            return true;
        }
        return false;
    }
    static void Elibibility(string str,Filter filter,float percentage)
    {
        System.Console.WriteLine(str);
        if(filter(percentage))
        {
            System.Console.WriteLine("You are eligibile");
        }
        else{
            System.Console.WriteLine("Not eligible");
        }
    }
    public static void Main(string[] args)
    {
        Elibibility("Arun",CheckEligibility,76);
    }
}

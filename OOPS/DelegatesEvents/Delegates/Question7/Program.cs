using System;
namespace Question7;
public delegate bool Filter (float percentage);
class Program{
    public static bool BE(float percentage)
    {
        if(percentage>60)
        {
            return true;
        }
        return false;
    }
    public static bool MBBS(float percentage)
    {
        if(percentage>95)
        {
            return true;
        }
        return false;
    }
    public static bool BDS(float percentage)
    {
        if(percentage>90)
        {
            return true;
        }
        return false;
    }
    public static bool BTechAgri(float percentage)
    {
        if(percentage>80)
        {
            return true;
        }
        return false;
    }
    public static void Eligibility(string str, Filter filter, float average)
    {
        System.Console.WriteLine(str);
        if(filter(average))
        {
            System.Console.WriteLine("You are eligible");
        }
        else 
        {
            System.Console.WriteLine("You are not eligible");
        }
    }
    public static void Main(string[] args)
    {
        Eligibility("Sathya", BTechAgri, 95);
        Eligibility("Syncfusion",BE, 65);
    }
}

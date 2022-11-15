using System;
namespace Question2;
public delegate bool Filter(int number);
class Program{
    public static bool IsBigger(int number)
    {
        if(number>50)
        {
            return true;
        }
        return false;
    }
    public static bool IsSmaller(int number)
    {
        if(number<50)
        {
            return true;
        }
        return false;
    }
    public static void Comparison(Filter filter,int number)
    {

        if(filter(number))
        {

            System.Console.WriteLine("number greater than 50 is "+number);
        }
        else
        {
            System.Console.WriteLine("number lesser than 50 is "+number);
        }
    }
    public static void Main(string[] args)
    {
        int[] arr= {45,33,22,66,43,77,88,55,52,90,33};
        foreach(int item in arr)
        {
            Comparison(IsBigger,item);
        }
    }
}

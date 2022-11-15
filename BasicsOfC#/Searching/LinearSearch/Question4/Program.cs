using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array");
        int size=Convert.ToInt32(Console.ReadLine());
        float []arr=new float[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a number :");
            arr[i]=Convert.ToSingle(Console.ReadLine());
        }
        System.Console.Write("Enter a number to be searched ");
        float search=Convert.ToSingle(Console.ReadLine());
        Searching(arr,search);
    }
    public static void Searching(float []arr,float Search)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==Search)
            {
                System.Console.WriteLine($"Element found at {i}");
                return ;
            }
        }
        System.Console.WriteLine("Element not found");
    }
}
using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array");
        int size=Convert.ToInt32(Console.ReadLine());
        int []arr=new int[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a number :");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        System.Console.Write("Enter a number to be searched ");
        int search=Convert.ToInt32(Console.ReadLine());
        Searching(arr,search);
    }
    public static void Searching(int []arr,int Search)
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
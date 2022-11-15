using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        string []arr=new string[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a string :");
            arr[i]=Console.ReadLine();
        }
        System.Console.Write("Enter a string to be searched ");
        string search=Console.ReadLine();
        Searching(arr,search);
    }
    public static void Searching(string []arr,string Search)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i].Equals(Search))
            {
                System.Console.WriteLine($"Element found at {i}");
                return ;
            }
        }
        System.Console.WriteLine("Element not found");
    }
}
using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        char []arr=new char[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a character :");
            arr[i]=Console.ReadLine()[0];
        }
        System.Console.Write("Enter a character to be searched ");
        char search=Console.ReadLine()[0];
        Searching(arr,search);
    }
    public static void Searching(char []arr,char search)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i].Equals(search))
            {
                System.Console.WriteLine($"Element found at {i}");
                return ;
            }
        }
        System.Console.WriteLine("Element not found");
    }
}
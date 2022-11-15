using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        int size;
        Console.Write("Input the number of elements to be stored in the array :");
        size=Convert.ToInt32(Console.ReadLine());
        int []arr=new int[size];
        Console.WriteLine($"Enter the input for {size} elements ");
        int input;
        for(int i=0;i<arr.Length;i++)
        {
            Console.Write($"element - {i} : ");
            input=Convert.ToInt32(Console.ReadLine());
            arr[i]=input;
        }
        Console.Write("Elements in the array are : ");
        foreach(int var in arr)
        {
            Console.Write($"{var} ");
        }
    }
}

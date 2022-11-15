using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        int size;
        Console.Write("Input the number of elements to be stored in the array :");
        size=Convert.ToInt32(Console.ReadLine());
        int []arr=new int[size];
        Console.WriteLine($"Input {size} elments in the array");
        int input;
        for(int i=0;i<arr.Length;i++)
        {
            Console.Write($"element - {i} : ");
            input=Convert.ToInt32(Console.ReadLine());
            arr[i]=input;
        }

        Console.Write("The values stored in the array are : ");
        foreach(int var in arr)
        {
            Console.Write($"{var} ");
        }
        Console.WriteLine();
        Console.Write("The values stored in the array in reversed form :");
        for(int i=arr.Length-1;i>=0;i--)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}

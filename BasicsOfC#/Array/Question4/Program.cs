using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        int size;
        Console.Write("Input the number of elements to be stored in the array :");
        size=Convert.ToInt32(Console.ReadLine());
        int []arr=new int[size];
        Console.WriteLine($"Input {size} elments in an array");
        int input;
        for(int i=0;i<arr.Length;i++)
        {
            Console.Write($"element - {i} : ");
            input=Convert.ToInt32(Console.ReadLine());
            arr[i]=input;
        }
        // Maximum and minimum
        int max=arr[0];
        int min=arr[0];
        for(int i=1;i<arr.Length;i++)
        {
            if(max<arr[i])
            {
                max=arr[i];
            }
            else
            {
                min=arr[i];
            }
        }
        Console.WriteLine($"Maximum element is {max}");
        Console.WriteLine($"Minimum element is {min}");

    }
}
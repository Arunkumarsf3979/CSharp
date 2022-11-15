using System;
namespace Question5;
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

        // Even and odd in array
        Console.Write("The even elements are :");
        foreach (int var in arr)
        {
            if(var%2==0)
            {
                Console.Write($"{var} ");
            }
        }
        Console.WriteLine();

        Console.Write("The odd elements are :");
        foreach (int var in arr)
        {
            if(var%2!=0)
            {
                Console.Write($"{var} ");
            }
        }
    }
}

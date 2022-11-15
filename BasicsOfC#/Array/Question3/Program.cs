using System;
namespace Question3;
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
        int sum=0;
        for(int i=0;i<arr.Length;i++)
        {
            sum=sum+arr[i];
        }
        Console.Write($"The sum of elements in array :{sum}");
    }
}

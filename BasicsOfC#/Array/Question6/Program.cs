using System;
namespace Question6;
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
        // sorting
        bool value;
        int temp;
        for(int i=0;i<arr.Length;i++)
        {
            value=true;
            for(int j=0;j<arr.Length-1;j++)
            {
                if(arr[i]<arr[j])
                {
                    value=false;
                    temp=arr[i];
                    arr[i]=arr[j];
                    arr[j]=temp;
                }
            }
            if(value)
            {
                break;
            }
        }

        Console.Write("Elements of array in sorted ascending order: ");
        foreach (int var in arr)
        {
            Console.Write($"{var} ");
        }
        Console.WriteLine();
        
    }
}
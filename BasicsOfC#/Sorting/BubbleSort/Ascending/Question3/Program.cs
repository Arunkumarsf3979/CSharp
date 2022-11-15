using System;
namespace BubbleSort;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        char []arr=new char[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a number :");
            arr[i]=Console.ReadLine()[0];
        }


        // bubble sort
        char temp;
        for(int i=0;i<arr.Length-1;i++)
        {
            for(int j=0;j<arr.Length-i-1;j++)
            {
                if(arr[j]>arr[j+1])
                {
                    temp=arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        }
        foreach(char values in arr)
        {
            System.Console.WriteLine(values);
        }
    }
}

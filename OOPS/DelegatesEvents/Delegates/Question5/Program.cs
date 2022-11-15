using System;
namespace Question5;
public delegate bool Filt (int a, int b);
class Program{
    // static int[] 
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        int []arr=new int[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a number :");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        foreach(int item in Sort(arr, IsDescending))
        {
            System.Console.WriteLine(item);
        }
        bool IsAscending(int a, int b)
        {
            if(a>b)
            {
                return true;
            }
            return false;
        }
        bool IsDescending(int a, int b)
        {
            if(a<b)
            {
                return true;
            }
            return false;
        }

        int[] Sort(int []arr, Filt filter)
        {
            int temp;
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=0;j<arr.Length-i-1;j++)
                {
                    if(filter(arr[j],arr[j+1]))
                    {
                        temp=arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                    }
                }
            }
            return arr;
        }
    }
}

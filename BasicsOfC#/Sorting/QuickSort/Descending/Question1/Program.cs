using System;
namespace QuickSort;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        int []arr=new int[size];
        for(int k=0;k<arr.Length;k++)
        {
            System.Console.Write("Enter a number :");
            arr[k]=Convert.ToInt32(Console.ReadLine());
        }
        Quick(arr,0,arr.Length-1);
        foreach(int item in arr)
        {
            System.Console.WriteLine(item);
        }
    }
    static int Partition (int[] arr, int start, int end)  
    {  
        int pivot = arr[end];  
        int i = (start - 1);  
        int temp;
        for (int j = start; j <= end - 1; j++)  
        {  
            
            if (arr[j] > pivot)  
            {  
                i++; 
                temp = arr[i];  
                arr[i] = arr[j];  
                arr[j] = temp;  
            }  
        }  
        temp = arr[i+1];  
        arr[i+1] = arr[end];  
        arr[end] = temp;  
        return (i + 1);
    }
    static void Quick(int []arr, int start, int end) 
    {  
        if (start < end)  
        {  
            int pos = Partition(arr, start, end);
            Quick(arr, start, pos - 1);  
            Quick(arr, pos + 1, end);  
        }  
    }  
}



  


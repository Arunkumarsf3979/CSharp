using System;
namespace Question1;
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

        int i, j, temp;  
        for (i = 1; i < arr.Length; i++)
        {  
            temp = arr[i];  
            j = i - 1;  
  
            while(j>=0 && temp <= arr[j])   
            {    
                arr[j+1] = arr[j];     
                j = j-1;    
            }    
            arr[j+1] = temp;   
        } 
        foreach(int item in arr)
        {
            System.Console.WriteLine(item);
        }
    }  
} 

    
    

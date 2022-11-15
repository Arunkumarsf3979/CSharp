using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        float []arr=new float[size];
        for(int k=0;k<arr.Length;k++)
        {
            System.Console.Write("Enter a number :");
            arr[k]=Convert.ToSingle(Console.ReadLine());
        }

        int i, j;
        float temp;  
        for (i = 1; i < arr.Length; i++)
        {  
            temp = arr[i];  
            j = i - 1;  
  
            while(j>=0 && temp >= arr[j])   
            {    
                arr[j+1] = arr[j];     
                j = j-1;    
            }    
            arr[j+1] = temp;   
        } 
        foreach(float item in arr)
        {
            System.Console.WriteLine(item);
        }
    }  
} 

    
    


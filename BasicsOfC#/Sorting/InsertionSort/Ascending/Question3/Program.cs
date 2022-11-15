using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        char []arr=new char[size];
        for(int k=0;k<arr.Length;k++)
        {
            System.Console.Write("Enter a number :");
            arr[k]=Console.ReadLine()[0];
        }

        int i, j;
        char temp;  
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
        foreach(char item in arr)
        {
            System.Console.WriteLine(item);
        }
    }  
} 

    
    

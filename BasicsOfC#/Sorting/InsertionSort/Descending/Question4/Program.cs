using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        string []arr=new string[size];
        for(int k=0;k<arr.Length;k++)
        {
            System.Console.Write("Enter a number :");
            arr[k]=Console.ReadLine();
        }

        int i, j; 
        string temp;  
        for (i = 1; i < arr.Length; i++)
        {  
            temp = arr[i];  
            j = i - 1;  
  
            while(j>=0 && temp.CompareTo(arr[j])>=0)   
            {    
                arr[j+1] = arr[j];     
                j = j-1;    
            }    
            arr[j+1] = temp;   
        } 
        foreach(string item in arr)
        {
            System.Console.WriteLine(item);
        }
    }  
} 

    
    

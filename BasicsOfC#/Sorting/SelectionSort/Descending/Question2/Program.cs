using System;
namespace SelectionSort;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        float []arr=new float[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a number :");
            arr[i]=Convert.ToSingle(Console.ReadLine());
        }

        // SelectionSort
        int j,small;  
        for (int i=0; i<arr.Length-1; i++)   
        {  
            small=i;  
          
            for (j=i+1; j<arr.Length; j++) 
            { 
                if (arr[j]>arr[small])  
                {
                    small=j;  
                }
            }
            float temp=arr[small];  
            arr[small]=arr[i];  
            arr[i]=temp;  
        }
        foreach(float val in arr)
        {
            System.Console.WriteLine(val);
        }
    }
}

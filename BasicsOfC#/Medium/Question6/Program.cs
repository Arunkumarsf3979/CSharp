using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("enter the rows:");
        int row=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the columns:");
        int column=Convert.ToInt32(Console.ReadLine());
        int[,]arr1=new int[row,column];
        int[,]arr2=new int[row,column];
        int[,]add=new int[row,column];
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                Console.Write($"Input element [{i},{j}]:");
                arr1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                Console.Write($"Input element [{i},{j}]:");
                arr2[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        // first matrix
        Console.WriteLine("First matrix");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                Console.Write(arr1[i,j]+"  ");
            }
            Console.WriteLine();
        }
        // second matrix
        Console.WriteLine("second matrix");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                Console.Write(arr2[i,j]+"  ");
            }
            Console.WriteLine();
        }
        // addition matrix
        Console.WriteLine("Added matrix");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                add[i,j]=arr1[i,j]+arr2[i,j];
                Console.Write(add[i,j]+"  ");
            }
            Console.WriteLine();
        }
    }
    
}
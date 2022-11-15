using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("first matrix");
        Console.Write("enter the rows: ");
        int row1=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the columns: ");
        int column1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("second matrix");
        Console.Write("enter the rows: ");
        int row2=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the columns: ");
        int column2=Convert.ToInt32(Console.ReadLine());
        int [,]arr1=new int[row1,column1];
        int [,]arr2=new int[row2,column2];
        int [,]multiply=new int[row1,column2];
        Console.WriteLine("first matrix");
        for(int i=0;i<row1;i++)
        {
            for(int j=0;j<column1;j++)
            {
                Console.Write($"element [{i},{j}]: ");
                arr1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("second matrix");
        for(int i=0;i<row2;i++)
        {
            for(int j=0;j<column2;j++)
            {
                Console.Write($"element [{i},{j}]: ");
                arr2[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("first matrix");
        for(int i=0;i<row1;i++)
        {
            for(int j=0;j<column1;j++)
            {
                Console.Write(arr1[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("second matrix");
        for(int i=0;i<row2;i++)
        {
            for(int j=0;j<column2;j++)
            {
                Console.Write(arr2[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Multiplied matrix");
        for(int i=0;i<row1;i++)
        {
            for(int j=0;j<column2;j++)
            {
                for(int k=0;k<column1;k++)
                {
                    multiply[i,j]=multiply[i,j]+arr1[i,k]*arr2[k,j];
                }
            }
        }
        for(int i=0;i<row1;i++)
        {
            for(int j=0;j<column2;j++)
            {
                Console.Write(multiply[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}
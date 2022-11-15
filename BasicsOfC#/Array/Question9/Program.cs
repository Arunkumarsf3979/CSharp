using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Matrix 1:");
        Console.Write("Enter the rows: ");
        int row=Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the columns: ");
        int column=Convert.ToInt32(Console.ReadLine());

        int[,]arr=new int[row,column];
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                Console.Write("Element [i][j] - ");
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
                
            }
        }

        Console.WriteLine("Matrix 2:");
        Console.Write("Enter the rows: ");
        int row2=Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the columns: ");
        int column2=Convert.ToInt32(Console.ReadLine());

        int[,]arr2=new int[row,column];
        for(int i=0;i<row2;i++)
        {
            for(int j=0;j<column2;j++)
            {
                Console.Write("Element [i][j] - ");
                arr2[i,j]=Convert.ToInt32(Console.ReadLine());
                
            }
        }

        Console.WriteLine("The first matrix is:");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("The second matrix is:");
        for(int i=0;i<row2;i++)
        {
            for(int j=0;j<column2;j++)
            {
                
                Console.Write($"{arr2[i,j]} ");
            }
            Console.WriteLine();
        }

        // Matrix Multiplication
        Console.WriteLine("The multiplication of two matirx is: ");
        int [,]multiply=new int[row,column];
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                for(int k=0;k<row;k++)
                {
                    multiply[i,j]=multiply[i,j]+arr[i,k]*arr2[k,j];
                }
                Console.Write(multiply[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}

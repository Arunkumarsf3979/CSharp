using System;
namespace Question8;
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
        // Addition of Matrix
        Console.WriteLine("The additon of two matrix is:");
        int [,]add=new int[row,column];
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                add[i,j]=arr[i,j]+arr2[i,j];
                Console.Write(add[i,j]+" ");
            }
            Console.WriteLine();
        }

    }
}
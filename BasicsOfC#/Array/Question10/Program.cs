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
        Console.WriteLine("The first matrix is:");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
        }

        // Transpose
        Console.WriteLine("The Transpose of a matrix is : ");
        int [,]transpose=new int[row,column];
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                transpose[i,j]=arr[j,i];
                Console.Write(transpose[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}
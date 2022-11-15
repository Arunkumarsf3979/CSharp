using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the rows: ");
        int row=Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the rows: ");
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
        Console.WriteLine("The matrix is : ");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
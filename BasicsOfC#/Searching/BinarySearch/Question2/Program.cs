using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=Convert.ToInt32(Console.ReadLine());
        string []arr=new string[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a number :");
            arr[i]=Console.ReadLine();
        }
        System.Console.Write("Enter a string to be searched ");
        string search=Console.ReadLine();
        BinarySearching(arr,search);
    }
    public static void BinarySearching(string []arr,string search)
    {
        int start=0;
        int end=arr.Length-1;
        int mid;
        while(start<=end)
        {
            mid=(end+start)/2;
            int result=search.CompareTo(arr[mid]);
            if(result==0)
            {
                System.Console.WriteLine($"Element found at {mid}");
                return;
            }
            else if(result<0)
            {
                end=mid-1;
            }
            else
            {
                start=mid+1;
            }
        }
        System.Console.WriteLine("Not found");
    }
}

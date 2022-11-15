using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        String[]arr=new String[5];
        for(int i=0;i<arr.Length;i++){
            Console.Write("Enter the name: ");
            arr[i]=Console.ReadLine();
        }
        Console.WriteLine("The names present in the array are :");
        for(int i=0;i<arr.Length;i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.Write("Enter the name to be searched :");
        String search=Console.ReadLine();
        bool value=false;
        Console.WriteLine("using forloop");
        for(int i=0;i<arr.Length;i++)
        {
            if(search==arr[i])
            {
                Console.WriteLine($"The {search} is present in the array of index {i}");
                value=true;
            }

        }
        if(value==false)
        {
            Console.WriteLine("The name is not present in the array.");
        }
        Console.WriteLine("using foreach");
        foreach(String var in arr)
        {
            if(search==var)
            {
                Console.WriteLine("The name is present in the array.");
                value=true;
            }
        }
        if(value==false)
        {
            Console.WriteLine("The name is not present in the array.");
        }
    }
}
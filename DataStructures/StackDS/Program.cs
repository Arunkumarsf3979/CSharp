using System;
namespace StackDS;
class Program{
    public static void Main(string[] args)
    {
        Stack<int> stack=new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        System.Console.WriteLine(stack.Count);
        int temp=stack.Count;
        if(stack.Contains(20))
        {
            System.Console.WriteLine("Element present");
        }
        else{
            System.Console.WriteLine("Element not present");
        }
        for(int i=0;i<temp;i++)
        {
            System.Console.WriteLine(stack.Peek());
            System.Console.WriteLine(stack.Pop());
        }
        
    }
}

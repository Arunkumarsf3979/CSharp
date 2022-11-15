using System;
namespace QueueDS;
class Program{
    public static void Main(string[] args)
    {
        Queue<int> queue=new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        System.Console.WriteLine(queue.Peek());
        queue.Dequeue();
        // queue.Dequeue();

        // System.Console.WriteLine(queue.Peek());
        
        // queue.Dequeue();
        // System.Console.WriteLine(queue.IsEmpty());
        // queue.Dequeue();
        // while(!queue.IsEmpty())
        // {
        //     System.Console.WriteLine(queue.Dequeue());
        // }
        foreach(var values in queue)
        {
            System.Console.WriteLine(queue.Dequeue());
        }
    }
}

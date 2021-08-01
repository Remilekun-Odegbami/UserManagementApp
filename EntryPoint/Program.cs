using System;
using System.Collections.Generic;
using Users;
using MyQueue;
using QueueLogic;
using UserFileManagement;

namespace EntryPoint
{
    class Program
    {
        static void Main(string[] args)

        {
            QueueUserInterface.Display();
            FileManagement.FileStuff();

            //UsersQueue<UserData> queue = new UsersQueue<UserData>();
            // queue.Enqueue("Hello1");
            // queue.Print();
            // queue.Enqueue("Hi"); 
            // queue.Print();
            // queue.Enqueue("Hi2"); 
            // queue.Print();
            // System.Console.WriteLine("------------------");
            // System.Console.WriteLine(queue.Dequeue("Hi"));
            // System.Console.WriteLine("------------------");
            // queue.Print();
            // System.Console.WriteLine("------------------");
            // System.Console.WriteLine(queue.Dequeue1());
            // System.Console.WriteLine("------------------");
            // queue.Print();
        }
    }
}

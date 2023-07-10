using c_sharp_datastruc_linkedList;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        linklist linklist = new linklist();
        linklist.Add(10);
        linklist.Add(20);
        linklist.Add(30);
        linklist.Add(40);

        linklist.Print();
        //linklist.Remove(30);

        //Console.WriteLine("this is after removing data:");
        // linklist.Print();

       // linklist.addInPosition(30,30);
        Console.WriteLine("this is after adding data in Position:");

        //  linklist.Print();

        //Console.WriteLine( linklist.Find(30));

        linklist.insertAtPosition(90, 2);
        linklist.Print();


    }
}
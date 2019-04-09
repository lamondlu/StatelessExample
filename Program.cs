using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Bug bug = new Bug("Hello World!");

            bug.Close();

            //Console.WriteLine($"Current State: {bug.CurrentState}");

            //bug.Assign("Lamond Lu");

            //Console.WriteLine($"Current State: {bug.CurrentState}");
            //Console.WriteLine($"Current Assignee: {bug.Assignee}");

            //bug.Defer();

            //Console.WriteLine($"Current State: {bug.CurrentState}");
            //Console.WriteLine($"Current Assignee: {bug.Assignee}");

            //bug.Assign("Lu Nan");

            //Console.WriteLine($"Current State: {bug.CurrentState}");
            //Console.WriteLine($"Current Assignee: {bug.Assignee}");

            //bug.Close();

            //Console.WriteLine($"Current State: {bug.CurrentState}");
        }
    }
}

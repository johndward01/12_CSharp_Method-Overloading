using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overloading_Exercise
{
    public class ConsoleWindowManager
    {
        public string Title { get; set; }

        public void PrintSomething()
        {
            Console.WriteLine("Something");
        }

        public ConsoleWindowManager(string firstName)
        {
                
        }

    }
}

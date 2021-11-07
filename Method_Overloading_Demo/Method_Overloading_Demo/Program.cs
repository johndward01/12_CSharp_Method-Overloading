using System;
using System.ComponentModel;
using System.Linq;

namespace Method_Overloading_Demo
{
    class Program
    {
        static void Main()
        {

        }        

        public int Add(int x, int y)
        {
            return x + y;
        }

        public void Add(int a, int b) // Method Overloading is not affected by the return type only the signature
        {
            Console.WriteLine(a + b);
        }
    }
}

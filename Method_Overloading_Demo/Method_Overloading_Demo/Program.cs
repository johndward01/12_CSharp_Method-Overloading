using System;
using System.ComponentModel;

namespace Method_Overloading_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods can have the same name as long as there SIGNATURES are different

            //Method Overloading allows methods of the same name to happily co-exist in the same program, providing their parameters differ in 
            //  1. Number or
            //  2. Data Type or
            //  3. Number AND Data Type

            // NUMBER of parameters differ (data type the same)
            Add(1, 2); 
            Add(1, 2, 3); 

            // DATA TYPE of parameters differ (number of parameters the same)
            Add(0, 1);
            Add(.1, .2);

            // NUMBER & DATA TYPES 
            Add(.001, .002, .003);
            Add(1, 2, 3, 4);
        }

        public static void Add(int x, int y)
        {
            Console.WriteLine($"The sum of {x} + {y} = {x + y}");
        }

        public static void Add(int w, int x, int y,int z)
        {
            Console.WriteLine($"The sum of {x} + {y} + {z} = {w + x + y + z}");
        }

        public static void Add(double x, double y)
        {
            Console.WriteLine($"The sum of {x} + {y} = {x + y}");
        }

        public static void Add( double x, double y, double z)
        {
            Console.WriteLine($"The sum of {x} + {y} + {z} = {x + y + z}");
        }
    }
}

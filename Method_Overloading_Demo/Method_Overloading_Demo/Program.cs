using System;
using System.ComponentModel;

namespace Method_Overloading_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Subtract(1000, 2);
            Console.WriteLine(true);
            Add(1, 1, 2);
            Add(1.99, 2.99);
        }


        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        //public static int Subtract(int x, int y)
        //{
        //    return x - y;
        //}




        //public static decimal Add(float x, decimal y)
        //{
        //    return (int)x + y;
        //}

        //public static double Add(double x, double y)
        //{
        //    return x + y;
        //}

        //public static decim





        //public static int Add(params int[] x)
        //{
        //    int answer = 0;

        //    foreach (var num in x)
        //    {
        //        answer += num;
        //    }

        //    return answer;
        //}

        
    }
}

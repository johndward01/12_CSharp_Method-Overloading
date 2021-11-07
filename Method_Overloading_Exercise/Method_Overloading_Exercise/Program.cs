using System;
using System.Linq;

namespace Method_Overloading_Exercise
{
    class Program
    {        

        public static void Main(string[] args)
        {
            var answer1 = Add(2, 2);
            var answer2 = Add(232445m, .28324847m);
            var answer3 = Add(0, 0, false);

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool conditional)
        {
            if (conditional && x + y != 1)
            {
                return $"{x + y} dollars";
            }
            else if (conditional && x + y == 1)
            {
                return $"{x + y} dollar";
            }
            else
            {
                return x + y.ToString();
            }
        }


        //Bonus
        //This Add overload will take care of ANY number of int parameters making the above Add methods redundant
        public static int Add(params int[] arr)
        {
            return arr.Sum();
        }

    }
}

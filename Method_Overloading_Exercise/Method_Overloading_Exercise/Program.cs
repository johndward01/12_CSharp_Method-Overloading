using System;
using System.Linq;

namespace Method_Overloading_Exercise
{
    class Program
    {        

        static void Main(string[] args)
        {

            //This way stores the value of this Add method in the variable "answer"
            var answer = Add(1, 2, true);
            //Console.WriteLine(answer);//Then it prints "anwer" to the console

            //This way prints the value of the Add method straight to the console with no variable creation required
            //Console.WriteLine(Add(1, 0, true));

            Console.WriteLine(Add(1, 2, false)); 

            
            //Add(123, 456);
            
            //Add(123.12M, 123.12M);


            //These 2 methods are for the bonus method down below.Uncomment That method and these 2 Lines to see 2 examples using the "param" keyword
            //Console.WriteLine(Add(1));
            //Console.WriteLine(Add(1, 3, 4, 5, 6, 7, 8, 8, 44, 43));



            //Subtract(56, 82);

        }       

        //This Add method takes 2 parameters OF TYPE INTEGER, x and y and returns the result
        static int Add(int x, int y)
        {
            return x + y;
        }

        

        //Another Overload for the Add method this time with TYPE DECIMAL
        static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        //Another Overload that has 2 int parameters and 1 bool parameter
        static string Add(int x, int y, bool conditional)
        {
            if (conditional == true)
            {
                if (x + y != 1)
                {
                    return $"{x + y} dollars";
                }
                else
                {
                    return $"{x + y} dollar";
                }
            }
            else
            {
                return (x + y).ToString();
            }
        }

        public static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2); 
        }


        //Bonus
        //This Add overload will take care of ANY number of int parameters making the above Add methods redundant
        //static int Add(params int[] arr)
        //{
        //    return arr.Sum();
        //}

    }
}

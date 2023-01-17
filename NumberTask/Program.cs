﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number class object 
            Numbers ob = new Numbers();
            // Data types
            int a=10, b=5;
            Console.WriteLine($"Result = {ob.workingWithNumbers(a, b)}");
            ob.precision(a,b);
            ob.overflowAndOwerlfow();
        }
    }
    public class Numbers
    {        
        public int workingWithNumbers(int a, int b)
        {
            int c = a + b;
            return c;
        }

        /// Precedence
        ////  
        public void precedence(int a, int b)
        {
            int pre = a + b * a / b;
            Console.WriteLine($"Precedence = {pre}");
        }
        /// Explore integer precision and limits
        //// Getting Quotient and remainder
        public void precision(int a, int b)
        {
            int quo = a / b;
            int rem = a / b;
            Console.WriteLine($"Quotient = {quo}\nRemainder = {rem}");
        }
        /// Explore integer max and min limits 
        //// Working with different DataTypes and Limits 
        public void overflowAndOwerlfow()
        {
            double max = int.MaxValue;
            double min = int.MinValue;
            Console.WriteLine($"Max Range = {max}\nMin Range = {min}");
            max = long.MaxValue;
            min = long.MinValue;
            Console.WriteLine($"Max Range = {max}\nMin Range = {min}");
            max = float.MaxValue;
            min = float.MinValue;
            Console.WriteLine($"Max Range = {max}\nMin Range = {min}");
            max = double.MaxValue;
            min = double.MinValue;
            Console.WriteLine($"Max Range = {max}\nMin Range = {min}");
            // if we cross the defined limits it will report us an error 
            int what = int.MaxValue  /* => delete this comment to make overflow <= + 3*/;
            Console.WriteLine($"Limit overflow: {what}"); 


            ///  The decimal type has a smaller range but greater precision than double
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }
        /// Explore integer precision and limits
        //// Getting Quotient and remainder
        public void decisions(int a, int b)
        {
                int a = 5;
                int b = 4;
                int c = 10;
                if (a + b < 10)
                    Console.WriteLine("The answer is less than 10.");

                //Make if and else work together
                if (a + b > 10)
                    Console.WriteLine("The answer is greater than 10");
                else
                    Console.WriteLine("The answer is not greater than 10");

                //Make if and else work with multiple condition using AND OR operators
                if (a + b > 10 && c==10 || b < a)
                    Console.WriteLine("The answer is greater than 10");
                else
                    Console.WriteLine("The answer is not greater than 10");

        }
        /// LOOPS 
        public void loops(int a, int b)
        {
                int counter = 0;
                int length = 5;
                Console.WriteLine($"The For loop counter");
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine($"The counter is {counter}");
                    counter++;
                }

                Console.WriteLine($"The while loop counter");
                while (counter < 10)
                {
                    Console.WriteLine($"The do-while loop counter");
                    counter++;
                }

                Console.WriteLine($"The counter is {counter}");
                do
                {
                    Console.WriteLine($"The counter is {counter}");
                    counter++;
                } while (counter < 10);

                // nested loops
                Console.WriteLine($"The Nested loop row and columns");
                for (int r = 0; r < length; r++)
                {
                    for (int c = 0; c < length; c++)
                    {
                        Console.WriteLine($"|{r}| + |{c}|");
                    }
                }

                // Task :
                int sum = 0;
                for (int n = 1; n < 21; n++)
                {
                if (n % 3 == 0)
                {
                    sum +=  n;
                }
                }
                Console.WriteLine($"The sum is {sum}");
        }

     

    }

}
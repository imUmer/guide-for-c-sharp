using System;

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


    }

}
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers ob = new Numbers();
            // 
            int a = 18;
            int b = 6;
            int c = a + b * a + 1;
            Console.WriteLine(c);
            Console.WriteLine(ob.workingWithNumbers(a, b));
        }
    }
    public class Numbers
    {        
        public int workingWithNumbers(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }

}
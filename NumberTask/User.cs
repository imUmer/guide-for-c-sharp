using System;

namespace HelloWorld
{
    public  class User
    {
         public void display(string name)
        {
            System.Console.WriteLine($"Hello from {name}");
        }

         public void add(int a, int b)
        {
            System.Console.WriteLine(a+b);
        }
    }

    class MyClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }

       
}
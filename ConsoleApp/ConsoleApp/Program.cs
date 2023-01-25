using System;

namespace HelloWorld
{

    class Program
    {

            static async public  Task<string> GetDataAsync() {
            var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync("https://example.com");
            return result;
        }
       static async public Task<string> ReadDataAsync()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://learn.microsoft.com/en-us/dotnet/csharp/async");
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        public delegate Action MyDelegate();

        static public void MyMethod(int a, int b)
        {
            System.Console.WriteLine(a+b);
        }
        static void Main(string[] args)
        {
            Numbers ob = new Numbers(10);
            ob.display();
            // Async on = new Async();
            // var result = await GetDataAsync();
            // Console.WriteLine(result);
            System.Console.WriteLine("Start");
            string result =  ReadDataAsync();
            Console.WriteLine(result);
            System.Console.WriteLine("End");
            //
            // Name name = new Name(nameM);
            // name("Umer");

            // MyDelegate obb = new MyDelegate(MyMethod);
            // obb(2,3);
            // System.Console.WriteLine($"This is from private var a : {ob.A}");
            // ob.display();
            // int a = 18;
            // int b = 6;
            // int c = a + b * a + 1;
            // Console.WriteLine(c);
            // Console.WriteLine(ob.workingWithNumbers(a, b));

            // int[] numbers = {1,2,3,4,5};
            // var lst = [1,2,3];
            // var numArray =
            //     from no in numbers
            //     where ( no % 2) == 0
            //     select no;
            
            // List<int> numlist = 
            //     (from no in numbers
            //         where (no % 2) != 0
            //         select no).ToList(); 
            //         System.Console.WriteLine(numlist.Count);
            // foreach (var item in lst)
            // {
            //     System.Console.WriteLine(item);
            // }
            
        }
    }
    public class Numbers
    {
        private int a;
        public int b;
        public Numbers()
        {

        }
        public Numbers(int value)
        {
            a = value;
        }
        public int A {
            get
            {
                return a;
            }

              set{
                a = value;
              }

               }
        public int display()
        {
            System.Console.WriteLine(a);
            return 1;
        }
        public int workingWithNumbers(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }

}
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number class object 
            Numbers ob = new Numbers();
            LoopAndDecisions obj = new LoopAndDecisions();
            ListCollections lstObj = new ListCollections();
            Generics<string> generics = new Generics<string>();
            Person person = new Person();
            // Data types
            int a=10, b=5;

            /// LoopAndDEcisions Class methods 
            lstObj.createlist( "Umer","BCS","B");

            /// LoopAndDEcisions Class methods 
            obj.decisions(2,4);        

            /// Numbers class methods 
            Console.WriteLine($"Result = {ob.workingWithNumbers(a, b)}");
            ob.precision(a,b);
            ob.overflowAndOwerlfow();

            // Creating Tuples and deconstructing Tuples
            (int, double) t = (2, 3.0);

            /// deconstruct method # 1 
            int a1;
            double b1;
            (a1, b1) = t;

            /// with declaring var 
            var t2 = (1,3);
            (int c, int d) = t2;

            Console.WriteLine($"a: {a1}; b: {b1}");
            Console.WriteLine($"c: {c}; d: {d}");

            // Lambds Expression 
            Action<string> greet = name => {
                Console.WriteLine($"Hey {name}");
            };
            greet("Umer");

            /// Lambda Function 
            Func<int, int, bool> compare = (x,y) => x==y;
            Console.WriteLine(compare(11,2));

            /// When we want to access the attributes which are private we cannot get them 
            /// beacause they are encapculated with access modifiers 
            /// But we have a way to acces those field by using properties 
            person.Name = "Umer";
            Console.WriteLine(person.Name);

            // using Indexer in Person class 
            person[0] = "Umer";
            person[1] = "Malik";
            Console.WriteLine(person[1]); 

            // Discards 

            var (_, _, year1, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);

            Console.WriteLine($"from year: {year1} : {pop2 - pop1:N0}");

            static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
            {
                int population1 = 0, population2 = 0;
                double area = 0;

                if (name == "New York City")
                {
                    area = 468.48;
                    if (year1 == 1960)
                    {
                        population1 = 7781984;
                    }
                    if (year2 == 2010)
                    {
                        population2 = 8175133;
                    }
                    return (name, area, year1, population1, year2, population2);
                }

                return ("", 0, 0, 0, 0, 0);
            }   

            // Generics in classes 
            generics.lst.Add("Umer");
            generics.lst.Add("Niaz");
            generics.display();

            // Iterators 
            Users users = new Users();
            foreach (var item in GetSingleDigitNumbers())
            {
               System.Console.WriteLine(item);
            }
        }
        public static IEnumerable<int> GetSingleDigitNumbers()
        {
            yield return 0;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
        }
        
    }
    [AttributeUsage(AttributeTargets.All)]
    class HelpAttribute : Attribute
    {
        public string HelpMessage { get; set; }
    }
    class Generics<U>
    {
        public List<U> lst;
        public Generics()
        {
            lst = new List<U>(3);
        }
        [Help(HelpMessage="It was used to display the info!")]
        public void display()
        {
            foreach (var item in lst)
            {
               System.Console.WriteLine($"{item}");
            }
        }
    }

    class Users
    {
         
        public IEnumerable<int> GetSingleDigitNumbers()
        {
            for (int i = 0; i < 10; i++)
            {   
                yield return i;
            }
        }
    }

    class Person
    {
        /// Encapsulated data 
        private string name; 
        private string[] arr = new string[10];
        // we can access that data using properties;
        public string Name    
        {
            get { return name; }    
            set { name = value; }   
        }


        // Define the indexer with this keyword and [] notation.
        public string this[int i]
        {
            // get { return arr[i]; }
            get => arr[i];
            set { arr[i] = value; }
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

    public class LoopAndDecisions
    {
         /// Explore Dicisions Statements
        //// 
        public void decisions(int a, int b)
        {
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
 
    public class ListCollections
    {
        List<string> users = new List<string>();
        /// Explore Creating Lists
        //// 
        public void createlist(string stdName, string className, string section)
        {
                var names = new List<string> { $"{stdName}", $"{className}", $"{section}" };
                foreach(var name in names)
                {
                    System.Console.WriteLine($"{name.ToUpper()}");
                } 
        }
        // Adding the value into the list 
        public void addingValueInList(string value)
        {
            users.Add(value);
        }
        /// Counting the members in the list
        public void countMembersInList()
        {
             System.Console.WriteLine($"The Total members are in list is: {users.Count}");
        }
    }
}
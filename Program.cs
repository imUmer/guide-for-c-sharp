static void Main(string[] args)
{
    // 
    int a = 18;
    int b = 6;
    int c = a + b * a + 1;
    Console.WriteLine(c);
    Console.WriteLine(workingWithNumbers(a, b));
}

int workingWithNumbers(int a, int b)
{
    int c = a + b;
    return c;
}


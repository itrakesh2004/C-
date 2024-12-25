class Program
{
    public static void Main(string[] args)
    {
        Hello("RRR");
        Console.WriteLine(Add(2,3));
    }

    // Parameter and Argument
    static void Hello(string name)
    {
        Console.WriteLine($"Hello World{name}");
    }

    // return value

    static int Add(int num1,int num2)
    {
        int sum=num1+num2;
        return sum;
    }
    
}
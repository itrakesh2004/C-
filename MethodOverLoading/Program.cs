class Program
{
    static void Main(string[] args)
    {
        int result = add(10, 20);
        Console.WriteLine(result);
        result = add(10, 20, 30);
        Console.WriteLine(result);
    }

    static int add(int num1, int num2)
    {
        return num1 + num2;
    }

    static int add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}
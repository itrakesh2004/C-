//IN keyword

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(sum(1,2,3,4,5));
        int number=10;
        Foo(number);
        Bar(out number);
    }
    static void Foo(in int n) //in keyword
    {
        //n=12; error
        int other=n;
        Console.WriteLine(other);

    }

    static void Bar(out int n) //out keyword
    {
        n=20;
        Console.WriteLine(n);
        
    }

    //params

    static int sum (params int[] numbers)
    {
        int total=0;
        foreach(int number in numbers)
        {
            total+=number;
        }
        return total;
    }
}
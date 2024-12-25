//IN keyword

class Program
{
    static void Main(string[] args)
    {
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
        Console.WriteLine(n);}


}
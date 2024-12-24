class Program
{
    static void Main(string[] args)
    {
        string str="123";
        int a=int.Parse(str);
        Console.WriteLine(a);
        Console.WriteLine(a.GetType());

        int num=123;
        string str2=num.ToString();
        Console.WriteLine(str2.GetType());

    }
}
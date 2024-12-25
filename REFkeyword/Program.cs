class Program
{
    static void Main(string[] args)
    {
        int number=10;
        ref int refNumber=ref number;  //referance create karvathi memory nave use kartu nathi
        refNumber=20;
        Console.WriteLine(number);
        refNumber=30;
        Console.WriteLine(number);
    }
}
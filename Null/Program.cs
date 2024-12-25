class Program
{
    public static void Main(string[] args)
    {
       string? name=null;
       string? a=name??"no name";
       Console.WriteLine(a);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person p=new();
        p.Name="ram";
        p.Age=20;
        Console.WriteLine(p.Name);
        Console.WriteLine(p.Age);

    }
}

class Person
{
    public string? Name  ;
    public int? Age;

}
class Program
{
    static void Main(string[] args)
    {
        Person p=new();
        Student s=new();
        p.Name="ram";
        p.Age=20;

        s.Name="shyam";
        s.Roll=30;

        Console.WriteLine(p.Name);
        Console.WriteLine(p.Age);

        Console.WriteLine(s.Name);
        Console.WriteLine(s.Roll);

    }
}

class Person
{
    public string? Name  ;
    public int? Age;

}
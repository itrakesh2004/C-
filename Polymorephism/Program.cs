interface IPerson
{
    void Display();
}

class Person : IPerson
{
    public void Display()
    {
        Console.WriteLine("Person");
    }
}

class Student : IPerson
{
    public void Display()
    {
        Console.WriteLine("Student");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPerson p = new Person(); //upcasting polymorephism
        p.Display();
        p = new Student(); //reference type
        p.Display();
    }
}
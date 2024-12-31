class Person
{
    public static string name="ram";

    public static void Display()
    {
        Console.WriteLine($"name:{name}");
    }
}

class Student 
{
    public static void std()
    {
        Console.WriteLine("student");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        //not use ststatic keyword
        // Person p=new Person();
        // p.Display();

        //use static keyword
        Person.Display();               
        Student.std();
    }
}
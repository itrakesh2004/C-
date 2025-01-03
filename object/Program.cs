// Console.WriteLine("Hello, World!");

class Person
{
    public string name { get; set; }
    public int age { get; set; }
}

class Program
{
    public static void Main(string[] args)
    {
        // Person p = new Person()
        List<Person> obj = new List<Person>
        {
            new Person { name = "ram", age = 20 },
            new Person { name = "shyam", age = 30 }
        };
       Console.WriteLine(obj.Count);

      //Create data
       Create(new Person { name = "ram2", age = 20 });
        static void Create(Person p)
        {
            Console.WriteLine(p.name);
        }    
    }
}
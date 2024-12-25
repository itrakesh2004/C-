class Person
{
     private string name;
     private int age;

     //Constructor

     public Person(string name, int age)
     {
        this.name=name;
        this.age=age;
     }

     public void Display()
     {
        Console.WriteLine($"name:{name} || age: {age}");
     }
}

class Program
{
    public static void Main(string[] args)
    {
       Person p=new("ram",20);
       p.Display();

    }
}
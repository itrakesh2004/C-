public class Animal
{
    public void Eat()
    {
        Console.WriteLine("eating...");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("barking...");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Dog d = new Dog();
        d.Bark();
        d.Eat();
    }
}
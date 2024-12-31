abstract class Animal
{
    public abstract void Eat();  // abstract method aa method badha class ma vaprvij pade
    public void sleep()
    {
        Console.WriteLine("aleeping...");
    }
}
class Pig : Animal
{
    public override void Eat()
    {
        Console.WriteLine("eating...");
    }

    public void sleep2()
    {
        Console.WriteLine("sleeping...");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Pig p = new Pig();
        p.Eat();
        p.sleep();
        p.sleep2();

    }
}
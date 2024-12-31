interface Ivehicle
{
    void drive();
    void stop();
}                   

class Car : Ivehicle
{
    public void drive()
    {
        Console.WriteLine("car is driving");
    }
    public void stop()
    {
        Console.WriteLine("car is stopped");
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Car c = new Car();
        c.drive();
        c.stop();
    }
}
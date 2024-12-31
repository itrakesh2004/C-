class MainProgram
{
    static void Alert(string message) //delegate
    {
        Console.WriteLine(message);
    }

    static void Alert2(string message) //delegate
    {
        Console.WriteLine(message);
    }

    delegate void AlertDelegate(string message); //delegate type

    static void Main(string[] args)
    {
        AlertDelegate ad = Alert; //not create object but only Refernce

        ad.Invoke("Hello");
        ad += Alert2;
        ad.Invoke("Hello2");

    }
}
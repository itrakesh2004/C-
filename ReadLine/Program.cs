﻿class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your name is {name} and your age is {age}");
       
    }
}
class Program
{
    static void Main(string[] args)
    {

        string str = "Hello World";
        Console.WriteLine(str.Length); //Length

        Console.WriteLine(str.ToUpper()); //Upper
        Console.WriteLine(str.ToLower()); //Lower

        Console.WriteLine(str.Contains("World")); //Contains

        Console.WriteLine(str.StartsWith("Hello")); //StartsWith

        Console.WriteLine(str.EndsWith("World")); //EndsWith

        Console.WriteLine(str.Substring(6, 5)); //Substring

        Console.WriteLine(str.Replace("World", "Worlds")); //Replace

        Console.WriteLine(str.Trim()); //Trim

        Console.WriteLine(str.IndexOf("World")); //IndexOf

        Console.WriteLine(str.LastIndexOf("World")); //LastIndexOf

        Console.WriteLine(str.Insert(6, "Worlds")); //Insert

        string input = "this is a sentence."; // Split
        string[] words = input.Split(' ');
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }


    }
}
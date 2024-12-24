using System.Text;
class Program
{
    static void Main(string[] args)
    {
        // string str = "Hello World!"; // Create a string variable
        // string  str2=str; copy kari new memeory create hoga
        // Console.WriteLine(str2);

        
        //multiple time update value string use for string builder 


        StringBuilder sb = new ("Hello"); // Create a StringBuilder object 
        sb.Append(" How ");
        Console.WriteLine(sb);
        Console.WriteLine($"Length:{sb.Length}");
        Console.WriteLine($"Capacity:{sb.Capacity}");

}
}
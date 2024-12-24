class Program
{
    static void Main(string[] args)
    {
        string str="1234";
        int num=Convert.ToInt32(str);
        Console.WriteLine(num);




        string str1 = "1234.5";
        double num1 = Convert.ToDouble(str1); // Convert to double
        int num2 = (int)num1;                 // Explicitly cast double to int
        Console.WriteLine(num2);
     

        string str2="1234.5";
        decimal num3=Convert.ToDecimal(str2);
        Console.WriteLine(num3);

    }
}

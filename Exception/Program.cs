class Program
{
    static void Main(string[] args)
    {
        try
        {
            bool a = false;
            bool other = true;
            if(a)
            {
                throw new Exception("exception");
            }
            else if (other)
            {
                throw new ArgumentException("other exception");
            }
            else
            {
                Console.WriteLine("no exception");
            }
           
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
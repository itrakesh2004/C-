class Program
{
    static void Main(string[] args)
    {
        // int[] arr={1,2,3,4,5,6,7,8,9,10};

        // for(int i=0;i<arr.Length;i++)
        // {
        //     Console.WriteLine(arr[i]);
        // }

        // int[] arr=new int[10];
        // for(int i=0;i<arr.Length;i++)
        // {
        //     Console.WriteLine("enter the number:");
        //     arr[i]=Convert.ToInt32(Console.ReadLine());
        // }
        // Console.WriteLine("element of array is:");

        int[,] nunber={{1,2,3},{4,5,6}};

        // foreach(int i in nunber)
        // {
        //     Console.WriteLine(i);
        // }

        int a=nunber.GetLength(0);
        int b=nunber.GetLength(1);
      

       
        
        for(int i=0;i<a;i++)
        {
            for(int j=0;j<b;j++)
            
                {
                    Console.Write(nunber[i,j]+" ");
                }
                Console.WriteLine();
        }
    }
}
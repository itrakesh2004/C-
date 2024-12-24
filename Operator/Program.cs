class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter the number a:");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the number b:");
        int b=Convert.ToInt32(Console.ReadLine());

        Arithmatic operator

        int c=a+b;
        int d=a/b;
        int e=a%b;
        Console.WriteLine("sum{0} division {1} module {2} ",c,d,e);
        
        //logical operator

        bool a= true;
        bool b=false;

        if(a && b){
            Console.WriteLine("a and b is true");
        }
        else
        {
            Console.WriteLine(" not two value same");
        }

        if( a || b)
        {
            Console.WriteLine(" a true yaa b true");
        }    
        else{
            Console.WriteLine("two false");
        }   

        if(!a){
             Console.WriteLine("a false");
        }
        else{
             Console.WriteLine("a true");
        }


        //Conditional Operator

        int a=20;
        

        bool result= a>=18?true:false;
         Console.WriteLine(result);
       
    }
}
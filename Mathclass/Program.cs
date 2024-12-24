class MathExample{
    static void Main(){

        //constent
        Console.WriteLine($"pi value {Math.PI}");
        
        //absolute
        Console.WriteLine($"-10 abs:{Math.Abs(-10)}");

        //rounding
        Console.WriteLine($"Rounding 4.6:{Math.Round(4.6)}");
        Console.WriteLine($"Rounding 4.3:{Math.Round(4.3)}");

        //celling
        Console.WriteLine($"Rounding 4.0001:{Math.Ceiling(4.00001)}"); //5

        //clamp
        Console.WriteLine($"clamp :{Math.Clamp(15,0,10)}"); //10
        Console.WriteLine($"clamp :{Math.Clamp(-1,0,10)}"); //0
        Console.WriteLine($"clamp :{Math.Clamp(8,0,10)}");  //8

        //
        Console.WriteLine($"squre :{Math.Sqrt(16)}");
        
      
    }
}
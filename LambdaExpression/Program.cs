// two type of lambda expression

var sum = (int a, int b) => a + b; //lambda expression
Console.WriteLine(sum(10, 20));

var sum2 = (int a, int b) => { return a + b; }; //lambda expression
Console.WriteLine(sum2(10, 20));


////

List<int> num=new(){1,2,3,4,5}; //list
List<int> odd = num.Where(x => x % 2 != 0).ToList(); //lambda

foreach (int i in odd)
{
    Console.WriteLine(i);
}
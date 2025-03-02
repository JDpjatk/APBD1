// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("First Change!");
Console.WriteLine(test([1,3,5,2137]));
static double test(int[] args)
{ 
    int sum = 0;
    foreach(int i in args) {  sum += i; }

    return sum / args.Length;
    Console.WriteLine("test");
}
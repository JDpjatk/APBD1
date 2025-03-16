// See https://aka.ms/new-console-template for more information
Console.WriteLine(
test([1,3,5,2,4,14,5,5,2,2]));
static double test(int[] args)
{ 
    int sum = 0;
    foreach(int i in args) {  sum += i; }

    return sum / args.Length;
}
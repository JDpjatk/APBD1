// See https://aka.ms/new-console-template for more information
Console.WriteLine(
avarage([1,3,5,2,4,14,5,5,2,2]));
Console.WriteLine(max([1,3,5,2,4,14,5,5,2,2]));
static double avarage(int[] args)
{ 
    int sum = 0;
    foreach(int i in args) {  sum += i; }

    return sum / args.Length;
}

static int max(int[] args){
    int max = args[0];
    foreach(int i in args){
        if (i > max)
        {
            max = i;
        }
    }return max;

}
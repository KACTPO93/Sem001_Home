//
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int count = 1;
while(count<N)
{
    if (N % 2 ==0)
    {
    Console.WriteLine("N!");
    count = count + 1;
    }
     
}

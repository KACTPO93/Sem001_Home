//Программа которая на вход принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int sqr = a;
if (sqr % 2 ==0)
    {
    Console.WriteLine("Четное!");
    }
        else
        {Console.WriteLine("Нечётное!");
        }
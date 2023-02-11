//Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int max = a;
int min = a;
if (b > max) max = b;
Console.Write("min = ");
Console.WriteLine(min);
Console.Write("max = ");
Console.WriteLine(max);
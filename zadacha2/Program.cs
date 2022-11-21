//Задача 2: Напишите программу, которая на вход принимает два
// числа и выдаёт, какое число большее, а какое меньшее.

int a=-9;
int b=-3;
int Max = 0;
int Min = 0;

if (a>b)
{
Max = a;
Min = b;
}

Max = b;
Min = a;

Console.WriteLine(Max);
Console.WriteLine(Min);
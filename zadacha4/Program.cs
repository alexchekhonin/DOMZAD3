//Задача 4: Напишите программу, которая принимает на вход
//три числа и выдаёт максимальное из этих чисел.

int a=22;
int b=3;
int c=9;
int max=0;

if (a>b)
{
max = a;
}

if (b>a)
{
max = b;
}

if (c>max)
{
max = c;
}
Console.WriteLine(max);
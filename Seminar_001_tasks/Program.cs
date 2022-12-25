/* 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
        a = 25; b = 5 -> да
        а = 2; b = 10 -> нет
        a = 9; b = -3 -> да 
        a = -3 b =9 -> нет  */

int a = 0, b = 0;

Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);

int c = b * b;

if (a == c)
{
    Console.Write($"Да");
}
else
{
    Console.Write($"Нет");
}






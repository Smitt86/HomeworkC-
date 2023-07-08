// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

using System;
using static System.Console;

Clear();

WriteLine("Введите значение M");
int m = int.Parse(ReadLine()!);
WriteLine("Введите значение N");
int n = int.Parse(ReadLine()!);
WriteLine(SumValues(m, n));

int SumValues(int m, int n)
{
    if (m == n) return 0;
    return n + SumValues(m + 1, n - 1);
}
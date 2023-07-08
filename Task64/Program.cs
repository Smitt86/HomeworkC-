// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

using System;
using static System.Console;

Clear();

WriteLine("Введите значение N");
int n = int.Parse(ReadLine()!);
WriteLine(NaturNumbers(n));

string NaturNumbers(int num)
{
    if (num == 1) return num.ToString();
    string s = num.ToString() + ", " + NaturNumbers(num - 1);
    return s;
}
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

using System;
using static System.Console;

Clear();

WriteLine("Введите значение M");
int m = int.Parse(ReadLine()!);
WriteLine("Введите значение N");
int n = int.Parse(ReadLine()!);

Console.Write($"Функция Аккермана от {m} и {n} = {AckerMan(m,n)} ");

int AckerMan(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckerMan(m - 1, 1);
    else return AckerMan(m - 1, AckerMan(m, n - 1));
}
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

double[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array); // В задаче не указано, что мы должны вывести полученный массив, но...)

double[,] GetArray(int m, int n, int minvalue, int maxvalue)
{
    double[,] result = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rand.NextDouble()*100;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]:F2} ");
        }
        WriteLine();
    }
}

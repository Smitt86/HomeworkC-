// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
int[,] array1 = GetArray(rows, columns, 0, 10);
WriteLine("Первая матрица:");
PrintArray(array);
WriteLine("Вторая матрица:");
PrintArray(array1);
WriteLine("Результат произведения матриц:");
PrintArray(Proizvedenie(array, array1));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

int[,] Proizvedenie(int[,] array, int[,] array1)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = array[i, j] * array1[i, j];
        }

    }
    return result;
}
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;
using static System.Console;

Clear();

Write("Введите количество строк и столбцов массива: ");
int rows = int.Parse(ReadLine());
int columns = rows;

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
FindMinRow(array);

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

void FindMinRow(int[,] array)
{
    int minrow = 0;
    int sumrow = 0;
    int minrowindex = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minrow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumrow += array[i, j];
        if (sumrow < minrow)
        {
            minrow = sumrow;
            minrowindex = i;
        }
        sumrow = 0;
    }
    Write($"В данном массиве {minrowindex + 1}-я строка имеет наименьшую сумму элементов");
}
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Write("Введите номер строки массива: ");
int positionx = int.Parse(ReadLine()!);
Write("Введите номер столбца массива: ");
int positiony = int.Parse(ReadLine()!);
FoundAndPrint(array);

void FoundAndPrint(int[,] array)
{
    if (positionx < 0 | positionx > array.GetLength(0) - 1 |
    positiony < 0 | positiony > array.GetLength(1) - 1)

        WriteLine("Указанного элемента нет в массиве ");
    else
        WriteLine("Значение указанного элемента массива = {0}", array[positionx-1, positiony-1]);


}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
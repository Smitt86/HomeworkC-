// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.WriteLine("Какое количество элементов вы хотите видеть в вашем массиве?");

int size = int.Parse(Console.ReadLine()!);

int[] array = GetRandomArray(size, 100, 999);

Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Количество четных чисел = {SumChetNum(array)}");

int[] GetRandomArray(int s, int minvalue, int maxvalue)
{
    int[] result = new int[s];
    for (int i = 0; i < s; i++)
    {
        result[i] = new Random().Next(minvalue, maxvalue + 1);
    }
    return result;
}

int SumChetNum(int[] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (num % 2 == 0) count++;
    }
    return count;
}
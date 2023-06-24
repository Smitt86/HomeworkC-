// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

Console.WriteLine("Какое количество элементов вы хотите видеть в вашем массиве?");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetRandomArray(size, -100, 100);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Сумма всех эелементов на нечетных позициях равна {SumNeChet(array)}");


int[] GetRandomArray(int s, int minvalue, int maxvalue)
{
    int[] result = new int[s];
    for (int i = 0; i < s; i++)
    {
        result[i] = new Random().Next(minvalue, maxvalue + 1);
    }
    return result;
}

int SumNeChet(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    return sum;
}
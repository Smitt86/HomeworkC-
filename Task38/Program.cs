// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

Console.Clear();
Console.WriteLine("Какое количество элементов вы хотите видеть в вашем массиве?");
int size = int.Parse(Console.ReadLine()!);

double[] array = GetRandomArray(size, -100, 100);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Разница между максимальным и минимальным значением равна {Raznica(array):f3}");


double[] GetRandomArray(int s, double minvalue, double maxvalue)
{
    double[] result = new double[s];
    for (int i = 0; i < s; i++)
    {
        Random rand = new Random();
        result[i] = rand.Next(-100, 100) + rand.NextDouble();
    }
    return result;
}

double Raznica(double[] array)
{
    double min = 0;
    double max = 0;
    double razn = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min < array[i]) min = array[i];
        if (max > array[i]) max = array[i];
    }
    razn = max - min;
    return razn;
}
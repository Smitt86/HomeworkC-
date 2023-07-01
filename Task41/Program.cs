// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
int dlina = Prompt("Введите количество элементов");
int[] nabor = InputNabor(dlina);
PrintArray(nabor);
Console.WriteLine($"Количество элементов больше 0 = {Proverka(nabor)}");

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputNabor(int dlina)
{
    int[] array = new int[dlina];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-й элемент");
    }
    return array;
}

void PrintArray(int[] nabor)
{
    for (int i = 0; i < nabor.Length; i++)
    {
        Console.WriteLine($"{i + 1}-е число = {nabor[i]}");
    }
}

int Proverka(int[] nabor)
{
    int count = 0;
    for (int i = 0; i < nabor.Length; i++)
    {
        if (nabor[i] > 0) count++;
    }
    return count;
}

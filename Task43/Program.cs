// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.WriteLine("Введите k1");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b1");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2");
int k2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2");
int b2 = int.Parse(Console.ReadLine()!);

if (k1 == k2)
{
    Console.WriteLine("Линии не пересекаются!");
    return;
}
int x = (b2 - b1) / (k1 - k2);
int y = k1 * x + b1;
Console.WriteLine($"x = {x}, y = {y}");
//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Введите число для возведения в третью степень: ");
int value = int.Parse(Console.ReadLine()!);
for (int i = 1; i <=value; i++)
    {
        Console.Write($"{i} в кубе равно - >  ");
        Console.WriteLine(Math.Pow(i,3));
    }
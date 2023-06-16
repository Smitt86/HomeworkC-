//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine());
int num3 = num % 10;
if (num < 100) Console.WriteLine("Вы ввели не трёхзначное число");
else Console.WriteLine($"Третья цифра в трёхзначном числе - > {num3}");

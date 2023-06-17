//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

Console.WriteLine ("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);

if (N < 10000 || N > 99999) {
    Console.WriteLine ("Введено не пятизначное число");
    return;
    }

int n5 = N%10;
int n4 = N%100/10;
int n2 = N/1000%10;
int n1 = N/10000;

if (n1 == n5 || n2==n4) Console.WriteLine ("Данное число является палиндромом");

else Console.WriteLine ("Данное число не является палиндромом");
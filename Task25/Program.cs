// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
Console.WriteLine("Возводим число в натуральную степень!");
Console.WriteLine("Введите число, которое хотите возвести в степень!");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в котрую вы хотите возвести число!");
int step = Convert.ToInt32(Console.ReadLine());
int result = Vozvedenie(number, step);
Console.WriteLine($"Число {number} в степени {step} равно {result}");

int Vozvedenie(int num, int st)
{
    int i = 1;
    int res = 1;
    while (i <= st)
    {
        res = res * num;
        i++;
    }
    return res;
}


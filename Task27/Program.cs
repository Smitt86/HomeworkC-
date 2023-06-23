// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("Ищем сумму цифр одного введенного числа");
Console.WriteLine("Введите число!");
int number = Convert.ToInt32(Console.ReadLine());
int result = Summirovanie(number);
Console.WriteLine($"Сумма цифр числа{number} равна {result}");

int Summirovanie(int num)
{
int sum = 0;
while (num !=0)
{sum = sum + num%10;
num = num/10;
}
return sum;
}
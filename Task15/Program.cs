// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите номер дня недели");
int Daynumber = int.Parse(Console.ReadLine());
if (Daynumber >=1 && Daynumber < 6) Console.WriteLine("Это будний день");
else if(Daynumber == 6 || Daynumber == 7) Console.WriteLine("Это выходной день!");
else if(Daynumber < 1 || Daynumber > 7) Console.WriteLine("Дружище! В неделе только семь дней!");

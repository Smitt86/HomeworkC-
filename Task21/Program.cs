//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.WriteLine ("Введите координаты первой точки: ");
int firstx = int.Parse(Console.ReadLine()!);
int firsty = int.Parse(Console.ReadLine()!);
int firstz = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите координаты второй точки: ");
int secondx = int.Parse(Console.ReadLine()!);
int secondy = int.Parse(Console.ReadLine()!);
int secondz = int.Parse(Console.ReadLine()!);

Console.WriteLine 
($"Расстояние между двумя введенными точками равно -> {Math.Sqrt(Math.Pow(firstx-secondx,2)+Math.Pow(firsty-secondy,2)+Math.Pow(firstz-secondz,2)):f2}");  
  
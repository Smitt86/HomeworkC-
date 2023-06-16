Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine());
int num2 = (num /10%10);
Console.WriteLine($"Вторая цифра в нашем трёхзначном числе -> {num2}");
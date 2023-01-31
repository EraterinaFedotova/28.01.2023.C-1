// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
string s = Console.ReadLine();
int num = int.Parse(s);
int y = num % 10;

Console.WriteLine($"Первый метод(%10) :{y}");
Console.WriteLine("----------");
string otvet = Convert.ToString(s[2]);
Console.WriteLine($"Первый метод (через строку) :{otvet}");
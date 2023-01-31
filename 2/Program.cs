// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("{0} наибольшее число", a);
}
else
{
    Console.WriteLine("{0} наибольшее число", b);
}
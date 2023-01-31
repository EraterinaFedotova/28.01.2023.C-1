// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Clear();
Console.Write("Введите число: ");
string txtN = Console.ReadLine();
int endNum = Convert.ToInt32(txtN);
int num = 0;
Console.WriteLine($"Чётные числа из диапазона от 1 до {endNum}: ");
while (num < endNum)
{
    num++;
    if (num % 2 == 0) Console.Write($"{num} ");
}
Console.WriteLine(); 
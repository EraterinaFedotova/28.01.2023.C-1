﻿// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Вариант 1
int[] Numbers = {2, 3, 7};
for (int i = 0; i < 3; i++)
{
    int max = Numbers[0]; 
    if (Numbers[i] > max)
    {
        max = Numbers[i];
        Console.WriteLine();
        Console.WriteLine($"Максимальное число {max}");
    }
}



// вариант 2
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());
int[] Numbers = {a, b, c};
int max = Numbers[0];
for (int i = 0; i < 3; i++)
 {  
    if (Numbers[i] > max)
 {
        max = Numbers[i];
   }
 }
Console.WriteLine($"Максимальное число {max}");
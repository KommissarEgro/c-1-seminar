﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое целое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второое целое число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
if (numberFirst > numberSecond)
{

    Console.WriteLine($"{numberFirst} максимальное число");
}
else
{
    Console.WriteLine($"{numberSecond} максимальное  число");

}
// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Напишите первое целое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе  целое число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
if (numberFirst == numberSecond * numberSecond) {
    Console.WriteLine("Число является квадратом");
}
else {
    Console.WriteLine("Число не является квадратом");
}

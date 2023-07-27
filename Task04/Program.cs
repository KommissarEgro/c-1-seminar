// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Напишите первое целое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишиет второе целое число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите третье целое число: ");
int numberThirt = Convert.ToInt32(Console.ReadLine());

int max = numberFirst;

if(numberFirst > max){
    max = numberFirst;
    if (numberSecond > max)
    max = numberSecond;
    if (numberThirt > max)
    max = numberThirt; 
}

Console.WriteLine($"{max} максимальное число");


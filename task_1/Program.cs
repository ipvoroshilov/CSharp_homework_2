// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int x = Convert.ToInt32(Console.ReadLine());
while (x < 100 | x > 999)
{
    Console.WriteLine("Введено не трехзначное число. Введите трёхзначное число");
    x = Convert.ToInt32(Console.ReadLine());
}
int secondDigit = x/10%10;
Console.WriteLine($"{secondDigit}");
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int twonum = Convert.ToInt32(Console.ReadLine());
{
int result = (twonum / 10) % 10;
System.Console.WriteLine($"Вторая цифра числа: {Math.Abs(result)}");
}
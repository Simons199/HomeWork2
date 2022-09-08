//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
{
int result = (num / 10) % 10;
System.Console.WriteLine($"Вторая цифра числа: {Math.Abs(result)}");
}
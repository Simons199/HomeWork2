// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine("этот день выходной");
    }
    else if (dayNum < 1 || dayNum > 7)
    {
        Console.WriteLine("это вообще не день недели");
    }
    else Console.WriteLine("этот день не выходной");
}

CheckingTheDayOfTheWeek(dayNum);
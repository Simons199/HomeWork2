int num = ReadInt("Введите число: ");
int count = num.ToString().Length;
Console.Write(MakeArray(num, count));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MakeArray(int x, int y)
{
int result = 0;
    if (y < 3)
    {
        Console.Write("Третьей цифры нет:");
    }
    else
    {
        int z = 1;
        for (int i = y; i > 3; i--)
        {
            z = z * 10;
        }

        result = (x / z) % 10;
    }
return result;
}
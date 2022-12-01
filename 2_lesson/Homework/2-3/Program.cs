void Num(int num)
{
    if (num < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return;
    }

    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(Num(number));

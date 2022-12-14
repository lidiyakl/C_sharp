// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.

int Num(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите число");
        int a = int.Parse(Console.ReadLine());
        if (a > 0)
            count += 1;
    }
    return count;
}

Console.WriteLine("Введите количество чисел");
int M = int.Parse(Console.ReadLine());
Console.WriteLine(Num(M));
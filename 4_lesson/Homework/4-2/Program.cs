// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

int NumSum(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    return sum;
}

Console.WriteLine(NumSum(int.Parse(Console.ReadLine())));

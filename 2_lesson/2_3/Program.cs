// Напищите программу, которая принимает на вход число и проверяет, кратно ли оно
//одновременно 7 и 23.

string Crat(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        return "кратно";
    else
        return "некратно";
}

Console.WriteLine("Введите число");
int number = int.Parse (Console.ReadLine());

Console.WriteLine(Crat(number));

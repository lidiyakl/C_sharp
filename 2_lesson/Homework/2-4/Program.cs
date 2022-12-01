string Week(int num)
{
    if (num == 6 || num == 7)
        return "yes";
    else
        return "no";
}

Console.WriteLine("Введите число");
int number = int.Parse (Console.ReadLine());

Console.WriteLine(Week(number));

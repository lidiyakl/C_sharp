string Num(int num)
{
    if ((num > 99 && num < 1000) || (num > -1000 && num < -99))
        
        return $"{num/10 % 10}";
    
    return "error";
}

Console.WriteLine("Введите число");
int number = int.Parse (Console.ReadLine());

Console.WriteLine(Num(number));

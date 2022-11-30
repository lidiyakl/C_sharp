string Number(int num)
{
    Console.WriteLine(num);

    return $"{num/100 * 10 + num % 10}";
}

Console.WriteLine(Number (new Random().Next(100, 1000)));
        

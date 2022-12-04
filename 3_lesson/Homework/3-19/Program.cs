void Pal(int N)
{
    if(N > 9999 && N < 99999)
    {
        if(N % 10 == N / 10000 && N / 10 % 10 == N / 1000 % 10)
        {
            Console.WriteLine("да");
        }
        else
        {
          Console.WriteLine("нет");
        }
    }
    else
    {
        Console.WriteLine("error");
    }
}

Console.WriteLine("Введите число");
int chislo = int.Parse(Console.ReadLine());
Pal(chislo);
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int num = int.Parse (Console.ReadLine());

if ((num > 99 && num < 1000) || (num > -1000 && num < -99))
{
        num = num / 10;
        Console.WriteLine (num % 10);
}
        
else
{
    Console.WriteLine ("error");
}
        

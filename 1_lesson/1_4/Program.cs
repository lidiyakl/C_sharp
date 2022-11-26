// See https://aka.ms/new-console-template for more information
Console.Write("Введите число");
var y = Console.ReadLine();
int N = y == null ? 0 : int.Parse(y);
Console.WriteLine($"{Math.Abs(N)}");

Console.WriteLine("Введите число1: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число2: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число3: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}
else if (num3 > max)
{
    max = num3;
}

Console.WriteLine(max);



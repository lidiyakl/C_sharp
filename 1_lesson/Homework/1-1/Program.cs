Console.WriteLine("Введите число1: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число2: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
   Console.WriteLine($"max = {(num1)}"); 
}
else if (num2 > num1)
{
    Console.WriteLine($"max = {(num2)}");
}
else
{
    Console.WriteLine($"max = {(num2)}");
}
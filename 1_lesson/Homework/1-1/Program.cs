Console.WriteLine("Введите число1: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число2: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
   Console.WriteLine($"max = {(num1)}"); 
}
else
{
    Console.WriteLine($"max = {(num2)}");
}
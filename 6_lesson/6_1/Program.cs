// Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треуголник со сторонами такой длины.
//Теорем о неравенстве треуголника: каждая сторона треугольника меньше
//суммы длин двух других сторон.

void TryG()
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    if (a < b + c & b < a + c & c < a + b)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}

TryG();

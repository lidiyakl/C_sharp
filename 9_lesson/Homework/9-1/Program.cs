﻿// Задайте значение N. Напишите программу, которая выведет
// все четные натуральные числа  в промежутке от N до 1.

void Num(int a)
{
    if (a % 2 > 0) a = a - 1;
    if (a == 0) return;
    Num(a - 2);
    Console.Write($"{a} ");
}

Num(9);
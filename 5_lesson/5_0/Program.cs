﻿// Задайте массив из 12 элементов, заполненный случайными числами из промежутка
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void SumPosNeg(int[] arr)
{
    int pos, neg;
    pos=neg=0;

    for(int i=0; i< arr.Length; i++)
    {
       if(arr[i] >=0)
           pos +=arr[i];
       else
           neg+=arr[i];
    }
    Console.WriteLine($"Positiv: {pos}, negative: {neg}");
}

int[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);
SumPosNeg(arr_1);


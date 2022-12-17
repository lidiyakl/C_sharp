// Напишите программу, которая принимает на вход позиции
// элемента в двумерном массиве и взвращает значение этого
// элемента или же указание, что такого элемента нет.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

string Find(int[,] arr, int n, int m)
{
    if (n > arr.GetLength(0) || m > arr.GetLength(1) || n < 0 || m < 0)
        return "Такого числа в массиве нет";
    return $"{arr[m - 1, n - 1]}";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column,
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);

Console.WriteLine("Введите номер строки");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int M = int.Parse(Console.ReadLine());
Console.WriteLine(Find(arr_1, N, M));
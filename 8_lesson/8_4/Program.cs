// Задайте двумерный массив из целых чисел. Напишите
// программу, которая удалит строку и столбец, на пересечении
// которых расположен наименьший элемент массива.

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

(int,int) Min(int[,] arr)
{
    int min = arr[0, 0];
    (int,int) minind = (0,0);
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i = 1; i < row; i++)
        for (int j = 1; j < column; j++)
            if (arr[i, j] < arr[minind.Item1,minind.Item2])
                minind=(i,j);
    return minind;
}

void Print1(int[,] arr, (int,int) minind)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (i == minind.Item1 || j == minind.Item2) continue;
            Console.Write($"{arr[i, j],4} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column,
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);

(int,int) minIndex = Min(arr_1);

Print1(arr_1, minIndex);
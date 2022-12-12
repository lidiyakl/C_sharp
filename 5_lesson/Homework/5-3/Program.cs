// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
// элементом массива.

void Print(double[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
        arr[i] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);

    return arr;
}

double MaxMin(double[] arr)
{
    double max, min;
    max = min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        else if (arr[i] < min)
            min = arr[i];
    }
    double minmax = max - min;
    return minmax;
}

double[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(MaxMin(arr_1));

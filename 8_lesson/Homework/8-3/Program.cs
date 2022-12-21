// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
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

int[,] Proiz(int[,] arr, int[,] arr1)
{
    int row=arr.GetLength(0);
    int column = arr1.GetLength(1);
    int[,] arr2=new int[row,column]

    for(int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr2[i,j]=arr[i,j]*arr1[j,i]
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column,
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);

Console.Write("Enter the number of rows: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column1 = int.Parse(Console.ReadLine());
int[,] arr_2 = MassNums(row1, column1,
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_2);

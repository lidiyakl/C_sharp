// Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.

void Print(int[,] arr)
{
    int raw = arr.GetLength(0);
    int colomn = arr.GetLength(1);

    for (int i = 0; i < raw; i++)
        {
            for (int j = 0; j < colomn; j++)
                 Console.Write($"{arr[i, j]} ");
            Console.WriteLine();
        }
}

int[,] MassNums(int raw, int colomn, int from, int to)
{
    int[,] arr = new int[raw, colomn];

    for (int i = 0; i < raw; i++)
        for (int j = 0; j < colomn; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[,] MasClone(int[,] arr)
{
   int raw = arr.GetLength(0);
   int colomn = arr.GetLength(1);
   int[,] new_arr = new int [raw,colomn];

    for (int i = 0; i < raw; i++)
        {
            for (int j = 0; j < colomn; j++)
                new_arr[i, j]=arr[i,j];
        }
    return new_arr; 
}

int[,] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
int[,] arr_2=MasClone(arr_1);
Print(arr_2);

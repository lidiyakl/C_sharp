// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

int[] Massiv(int size)
{
    int[] collection = new int[size];
    int index = 0;
    while (index < size)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
    return collection;
}

void PrintArray(int[] collection)
{
    int ind = 0;
    int count = collection.Length;
    while (ind < count)
    {
        Console.Write($"{collection[ind]} ");
        ind++;
    }
    Console.WriteLine();
}

int[] collection2 = Massiv(int.Parse(Console.ReadLine()));
PrintArray(collection2);

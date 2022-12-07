// Напишите цикл, который принимает на вход два числа (А и В)
// И возводит число А в натуральную степень В.

int Step(int a, int b)
{
    int avb = 1;
    for (int i = 0; i < b; i++)
    {
        avb = avb * a;
    }

    return avb;
}

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());

Console.WriteLine(Step(A, B));
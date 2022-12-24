// Напищите программу, которая на вход принимает два числа
// А и В, и возводит число А в целую степень В с помощью рекурсии.

int Degree(int a, int b)
{
    if (b == 0) return 1;
    return Degree(a, b - 1) * a;
}

Console.WriteLine(Degree(2, 3));
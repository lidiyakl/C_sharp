// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y=k1*x+b1, y=k2*x+b2; значения b1, k1, b2, k2 
// задаются пользователем.

void Line(int b1, int k1, int b2, int k2)
{
    double x = (double)(b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"({x};{y})");
}

Line(int.Parse(Console.ReadLine()),
     int.Parse(Console.ReadLine()),
     int.Parse(Console.ReadLine()),
     int.Parse(Console.ReadLine()));
Console.WriteLine("Введите число");
string x = Console.ReadLine();
int N = int.Parse(x);
int A = 2;

while(A <= N)
{
    Console.Write($"{A}, ");
    A +=2;
}
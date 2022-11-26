Console.WriteLine("Введите число");
string x = Console.ReadLine();
int N = int.Parse(x);
int NegN = - N;

while(NegN <= N)
{
    Console.Write($"{NegN} ");
    NegN +=1;
}
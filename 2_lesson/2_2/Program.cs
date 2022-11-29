// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если чило 2 не кратно числу 1, 
//то программа выводит остаток от деления.

string Crat(int num, int num2)
{
    if (num % num2 == 0)
        return "кратно";
    else
        return $"некратно, остаток = {num % num2}";
}

Console.WriteLine("1 число");
int first = int.Parse (Console.ReadLine());
Console.WriteLine("2 число");
int second = int.Parse (Console.ReadLine());
Console.WriteLine(Crat(first, second));

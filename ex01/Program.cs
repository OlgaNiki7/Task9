//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int a = InputInt("Введите положительное число ");
int b = 1;
if (a < 1)
{
    Console.WriteLine("Ввели не положительное число");
}

int number(int a, int b)
{
    if (a == b)
        return a;
    else
        Console.Write($"{number(a, b + 1)}, ");
    return b;
}
Console.WriteLine(number(a, b));


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}


//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int M = InputInt1("Введите M: ");
int N = InputInt1("Введите N: ");
Console.WriteLine($"Сумма элементов от {M} до {N} = {Sum(M, N)}");

int InputInt1(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Sum(int M, int N)
{
    if (M == N)
        return N;
    return N + Sum(M, N - 1);
}

//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt2("Введите M: ");
int n = InputInt2("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int InputInt2(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}


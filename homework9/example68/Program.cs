/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.Clear();

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int result = AkkermanFunction(M, N);

Console.WriteLine($"Функция Аккермана A(m,n) = {result} ");

int AkkermanFunction(int M, int N)
{
    if (M == 0)
        return N + 1;
    else if (N == 0) 
        return AkkermanFunction(M - 1, 1);
    else 
        return AkkermanFunction(M - 1, AkkermanFunction(M, N - 1));
}
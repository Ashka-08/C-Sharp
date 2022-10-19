/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N. Рекурсивно
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

RecSum(M, N, 0);

void RecSum(int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма чисел в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    RecSum(M, N, sum);
}

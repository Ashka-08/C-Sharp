/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка (нумерация строк начинается с 1)*/

Console.Clear();

Console.Write("Введите число строк/столбцов: ");
int a = int.Parse(Console.ReadLine()!);

int[,] matr = new int[a, a];
FillArray(matr);
PrintArray(matr);

int[] sum = SumColumn(matr);
Console.Write("Суммы строк: ");
Console.WriteLine(String.Join(" ", sum));

FindMinSum(sum);

void FillArray(int[,] matr) 
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        matr[i, j] = rand.Next(0, 10);
        }
    }
}

void PrintArray(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] SumColumn(int[,] matr)
{
    int[] columnSum = new int[a];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        columnSum[i] += matr[i, j];
        }
    }
    return columnSum;
}

void FindMinSum(int[] sum)
{
    int minRow = sum[0];
    int index = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (minRow > sum[i])
            index = i;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов номер {++index}");
}
/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.Clear();

Console.Write("Введите число строк: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int b = int.Parse(Console.ReadLine()!);

int[,] matr = new int[a, b];
FillArray(matr);
PrintArray(matr);
SortArray(matr);
Console.WriteLine("");
PrintArray(matr);

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

void SortArray(int[,] matr)
{
    for (int row = 0; row < matr.GetLength(0); row++)
    {
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            for (int j = i + 1; j < matr.GetLength(1); j++)
            {
                if (matr[row, i] < matr[row, j])
                {
                    int temp = matr[row, i];
                    matr[row, i] = matr[row, j];
                    matr[row, j] = temp;
                }
            }
        }
    }
    
}
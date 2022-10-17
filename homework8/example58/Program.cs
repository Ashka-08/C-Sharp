/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/

Console.Clear();

Console.Write("Введите число строк/столбцов: ");
int a = int.Parse(Console.ReadLine()!);

int[,] matr1 = new int[a, a];
FillArray(matr1);
PrintArray(matr1);

Console.WriteLine("и");

int[,] matr2 = new int[a, a];
FillArray(matr2);
PrintArray(matr2);

Console.WriteLine("Произведение матриц равно:");

int[,] result = ProductMatr(matr1, matr2);
PrintArray(result);

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

int[,] ProductMatr(int[,] matr1, int[,] matr2)
{
    int[,] prodMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < prodMatr.GetLength(0); i++)
    {
        for (int j = 0; j < prodMatr.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                prodMatr[i,j] += matr1[i,k] * matr2[k,j];
            }
        }
    }
    return prodMatr;
}
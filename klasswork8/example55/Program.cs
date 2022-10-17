/*Задача 55
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
Если это невозможно, программа должна вывести ссобщение для пользователя.*/

Console.Clear();

Console.Write("Введите число строк: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int b = int.Parse(Console.ReadLine()!);

int[,] matr = new int[a, b];
FillArray(matr);
PrintArray(matr);
if (a == b)
{
    ChangeArray(matr);
    Console.WriteLine("");
    PrintArray(matr);
}
else
    Console.WriteLine("Число строк и столбцов должно быть равное!");

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

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = i; j < array.GetLength(1); j++)
    { 
        int m = array[i, j];
        array[i, j] = array[j, i];
        array[j, i] = m;
    }
    }
}
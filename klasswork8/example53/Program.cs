/*Задача 53
Задайте двумерный массив. Напишите программу, которая поменяет местами 
первую и последнюю строки массива.*/

Console.Clear();

int[,] array = new int[3, 3];
FillArray(array);
PrintArray(array);
Console.WriteLine("");
ChangeMas(array);
PrintArray(array);
 
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeMas(int[,] array)
{
    int temp = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = array[0, j];
            array[0, j] = array[array.GetLength(0) - 1, j];
            array[array.GetLength(0) - 1, j] = temp;
        }
}
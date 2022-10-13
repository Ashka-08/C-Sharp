/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1
7 -> такого числа в массиве нет*/

Console.Clear();

Random generator = new Random();
int m = generator.Next(2,5);
int n = generator.Next(2,5);

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

Console.Write("Введите i: ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите j: ");
int j = int.Parse(Console.ReadLine()!);

if(i < m && j < n)
{
    int element = array[i, j];
    Console.WriteLine($"Число массива с индексами {i}, {j} равно {element}");
}
else
    Console.WriteLine("такого числа в массиве нет");
 
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = generator.Next(0,10);
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

/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Clear();

Random generator = new Random();
int m = generator.Next(2,5);
int n = generator.Next(2,5);

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

double avarage = 0;nt j = 0; j < array.GetLength(1); j++)
{
for (i
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage += array[i, j];
    }
    avarage = avarage / n;
    Console.Write($"{avarage:f1}; ");
}
 
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
/*Задача 49
Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и 
замените эти элементы на их квадраты.
1 4 7 2    ->    1 4 7 2
5 9 2 3          5 81 2 9
8 4 2 4          8 4 2 4*/

Console.Clear();

int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
ReplaceDigit(array);
Console.WriteLine();
PrintArray(array);

void FillArray(int[,] array)
{
    Random generator = new Random();
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

void ReplaceDigit(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            //array[i, j] = array[i, j] * array[i, j];
            array[i,j] = (int)Math.Pow(array[i,j], 2);
        }
    }
}
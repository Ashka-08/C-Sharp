/*Задача 51
Задайте двумерный массив. Посчитайте сумму элементов на главной диагонали
(с индексами (0,0), (1,1) и т.д.)
1 4 7 2
5 9 2 3
8 4 2 4
Сумма = 1 + 9 + 2 = 12*/

Console.Clear();

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
int sum = FindSum(array);
Console.WriteLine($"Сумма чисел главной диагонали равна {sum}");
 
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

int FindSum(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
                result += array[i,j];
        }
    }
    return result;
}
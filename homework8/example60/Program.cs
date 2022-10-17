/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.Clear();

int[,,] matr = new int[2, 2, 2];
FillArray(matr);
PrintArray(matr);

void FillArray(int[,,] matr) 
{
    int[] tempArray = new int[matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)];
    int temp;
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        tempArray[i] = new Random().Next(10, 100);
        temp = tempArray[i];
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(10, 100);
                    j = 0;
                    temp = tempArray[i];
                }
                temp = tempArray[i];
            }
        }
    }
    int count = 0; 
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = tempArray[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        for (int k = 0; k < matr.GetLength(2); k++)
        {
            Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
        }
    }
}
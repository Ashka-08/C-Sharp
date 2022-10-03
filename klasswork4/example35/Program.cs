/* Создать массив из 123 случ чисел.
Найти кол-во чисел, которые лежат в отрезке [10,99]*/

int[] array = new int[123];
int count = 0;
FillArray(array);
FindCount(array, count);
Console.WriteLine(count);

int FindCount(int[] array, int count)
{
    for (int i = 0; i < 123; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            count++;  
    }
    return count;
}

void FillArray(int[] array) 
{
    Random rand = new Random();
    for (int i = 0; i < 123; i++)
    {
    array[i] = rand.Next(10, 20);
    }
}
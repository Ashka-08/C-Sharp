/*Найти произв-ние пар чисел в случайном массиве с начала и конца.
Результат в новом массиве
[1 2 3 4 5] -> [5 8 3]
[6 7 3 7] -> [36 21]*/

int size = new Random().Next(0, 10);
Console.WriteLine(size);

int[] array = new int[size];
FillArray(array);
PrintArray(array);

int size2 = size;
if (size % 2 == 0)
{
    size2 = size / 2;
}
else
{
    size2 = size / 2 + 1;
}


int[] array2 = new int[size2];
Product(array, array2);
PrintArray(array2);

void Product(int[] array, int[] array2)
{
    int i = 0;
    int j = size;
    while (i <= j)
    {
        if (i == j)
            array2[i] = array[i];
        else
        {
        array2[i] = array[i] * array[j];
        i++;
        j--;
        }
    }
}

void FillArray(int[] array) 
{
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
    array[i] = rand.Next(0, 10);
    }
}

void PrintArray(int[] array) 
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}

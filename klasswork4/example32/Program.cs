/*Замена элементов массива: положительные элементы заменить на отриц-ные и наоборот
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

Console.Clear();

int[] array = CreateArray();

PrintArray(array);
ChangeArray(array);
PrintArray(array);

int CreateArray(int[] array)
{
    int[] array = {-4, -8, 8, 2};
    return array;
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

void ChangeArray(int[] array)
{
    for (int i = 0; i < arrayLength; i++)
    {
    array[i] = -array[i];
    }
}
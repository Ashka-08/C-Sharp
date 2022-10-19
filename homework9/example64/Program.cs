/*Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = new int[number];
CreateArray(array);
Array.Reverse(array);
PrintArray(array);

void CreateArray(int[] array, int index = 0)
{
    if (index < array.Length)
    {
        array[index] = index + 1;
        CreateArray(array, ++index);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
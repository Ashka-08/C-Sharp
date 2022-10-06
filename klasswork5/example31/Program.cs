/*Задача 31
Задайте массив из 12 элементов, вводимых с консоли
-(заполненный случайными числами в промежутке от [-9, 9])-,
Напишите 2 функции:
-найти сумму положительных чисел
-найти сумму отрицательных чисел
пример:
[3, 9, -9, 1, 0, -7, 2, -1, 8, -3, -1, 6] -> 29 и -20*/

Console.Clear();

Console.WriteLine("Введите числа через пробел");
string input = Console.ReadLine()!;

int[] array = ParseToArray(input);

Console.WriteLine($"Положительная сумма чисел равна {PositiveSum(array)}");
Console.Write($"Отрицательная сумма числе равна {NegativeSum(array)}");

int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = int.Parse(stringArray[i]);
    }
    return result;
}

int PositiveSum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count += array[i];
    }
    return count;
}

int NegativeSum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            count += array[i];
    }
    return count;
}
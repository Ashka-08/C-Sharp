/*Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами или вручную. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.Clear();

Console.WriteLine("Введите числа через пробел");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);
int result = CountEvenDigits(array);

Console.WriteLine($"Количество четных чисел равно: {result}");

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

int CountEvenDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
/*Задача 36: Задайте одномерный массив, заполненный случайными числами 
или вучную. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Clear();

Console.WriteLine("Введите числа через пробел");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);
int result = SumDigits(array);

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {result}");

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

int SumDigits (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
/*Задача 38 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Clear();

Console.WriteLine("Введите числа через пробел");
string input = Console.ReadLine()!;
double[] array = ParseToArray(input);
double result = DifForMaxMin(array);

Console.WriteLine($"Разница между макс и мин элементов массива равна: {result}");

double[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    double[] result = new double[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        result[i] = double.Parse(stringArray[i]);
    }
    return result;
}

double DifForMaxMin (double[] array)
{
    double max = array[0];
    double min= array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    double diff = max - min;
    return diff;
}
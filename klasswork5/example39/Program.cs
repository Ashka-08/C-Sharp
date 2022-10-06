/*Задача 39
Напишите программу, которая перевернет одномерный массив 
(последний элемент будет на первом месте, а первый на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]*/

Console.Clear();

Console.WriteLine("Введите числа через пробел");
string input = Console.ReadLine()!;
int[] array = ParseToArray(input);
int[] result = Revers(array);

Console.WriteLine("Перевернутый массив:");
Console.WriteLine(String.Join(" ", result));

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

int[] Revers(int[] array)
{
    int j = array.Length - 1;
    for (int i = 0; i <= j; i++, j--)
    {
        int temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
    return array;
}

double a = new Random().NextDouble;
/* Задача 37
Напишите метод, который объединяет 2 массива в один.
[5 18 123 6 2] + [1 2 3] = [5 18 123 6 2 1 2 3]*/

Console.WriteLine("Введите числа первого массива через пробел");
string firstArray = Console.ReadLine()!;
Console.WriteLine("Введите числа второго массива через пробел");
string secondArray = Console.ReadLine()!;

int[] fArray = ParseToArray(firstArray);
int[] sArray = ParseToArray(secondArray);

int[] res = Connect(fArray, sArray);
Console.WriteLine("Новый массив:");
Console.WriteLine(String.Join(" ", res));
// split разбирает массив на элементы, а join собирает все воедино

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

int[] Connect(int[] firstArray, int[] secondArray)
{
    int resultLength = firstArray.Length + secondArray.Length;
    int[] result = new int[resultLength];
    int i = 0;
    int j = 0;
    while (i < resultLength)
    {
        for (i = 0; i < firstArray.Length; i++)
        {
        result[i] = firstArray[i];
        }
        for (i = firstArray.Length; i < resultLength; i++, j++)
        {
        result[i] = secondArray[j];
        }
    }
    return result;
}

/*int[] Connect(int[] firstArray, int[] secondArray)
{
    int[] result = new int[firstArray.Length + secondArray.Length];
    int j = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        result[j] = firstArray[i];
        j++;
    }
    for (int i = 0; i < secondArray.Length; i++)
    {
        result[j] = secondArray[j];
        j++;
    }
    return result;
}*/

/*Console.WriteLine("Введите числа первого массива через пробел");
string firstArray = Console.ReadLine()!;
Console.WriteLine("Введите числа второго массива через пробел");
string secondArray = Console.ReadLine()!;

int[] NewArray = ParseToArray(firstArray, secondArray);

Console.WriteLine(String.Join(" ", NewArray)); 

int[] ParseToArray(string str1, string str2)
{
    string str = str1 + ' ' + str2;
    string[] StringArray = str.Split(" ");
    int[] result = new int[StringArray.Length];
    for (int i = 0; i < StringArray.Length; i++)
    {
        result[i] = int.Parse(StringArray[i]);
    }
    return result;
}*/
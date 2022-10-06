/* Задача 35
Напишите метод, который суммирует 2 массива. Каждый элемент одного массива 
должен суммироваться с соответствующим элементом другого массива. 
Если длины массивов не равны, то должно появляться сообщение об ошибке.
[5 18 123 6 2] + [1 2 3 6 2] = [6 20 126 12 4] */

Console.WriteLine("Введите числа первого массива через пробел");
string firstArray = Console.ReadLine()!;
Console.WriteLine("Введите числа второго массива через пробел");
string secondArray = Console.ReadLine()!;

int[] fArray = ParseToArray(firstArray);
int[] sArray = ParseToArray(secondArray);

if (fArray.Length != sArray.Length)
{
    Console.WriteLine("Ошибка! Длины массивов не равны!");
}
else 
{
    int[] res = SumOfArray(fArray, sArray);
    Console.WriteLine("Сумма массивов:");
    Console.WriteLine(String.Join(" ", res));
}

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

int[] SumOfArray(int[] firstArray, int[] secondArray)
{
    int[] result = new int[firstArray.Length];
    for (int i = 0; i < firstArray.Length; i++)
    {
        result[i] = firstArray[i] + secondArray[i];
    }
    return result;
}
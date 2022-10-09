/*Задача 41: Пользователь вводит с клавиатуры число M, 
потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.

5
0
7
8
-2
-2 -> 2

5
1
-7
567
89
223-> 3*/

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[num];
Function(array);
Console.WriteLine($"Количество чисел больше 0 равно {CountDigits(array)}");

void Function(int[] array, int index = 0)
{
    if (index < array.Length)
    {
        array[index] = int.Parse(Console.ReadLine()!);
        Function(array, ++index);
    }
}

int CountDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count ++;
    }
    return count;
}
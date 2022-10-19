/*Задача 70: Напишите программу, которая печатает последовательность чисел, 
где каждое следующее равно сумме двух предыдущих. 
На вход принимает 3 числа: n1, n2 и N, 
где n1 n2 - первые числа последовательности, N – длина последовательности 
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26 */

// f(n1) = 3
// f(n2) = 4
// f(n3) = n1 + n2
// f(n4) = n2 + n3

Console.Clear();

Console.Write("Введите число n1: ");
int n1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите число n2: ");
int n2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int[] array = SumDigitArray(N, n1, n2);
PrintArray(array);

int[] SumDigitArray(int N, int n1, int n2)
{
    int[] array = new int[N];
    array[0] = n1;
    array[1] = n2;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

/*Console.Write("введите превое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("введите длину последовотельности: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write($"{num1} {num2} ");
for (int i = 1; i <= n-2 ; i++)
{
int num3 = num1 + num2;
Console.Write($"{num3} ");
num1 = num2;
num2 = num3;
}*/
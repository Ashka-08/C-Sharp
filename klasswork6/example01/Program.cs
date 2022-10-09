/*Задача/ Напишите программу, которая будет рекурсивно 
выводить каждый элемент массива в консоль*/

Console.Clear();

int[] array = { 1, 12, 31, 4, 18 };
PrintArray(array);

void PrintArray(int[] array, int index = 0)
{
    if (index < array.Length)
    {
        Console.Write($"{array[index]} ");
        PrintArray(array, ++index);
    }
}

//if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
    
// }
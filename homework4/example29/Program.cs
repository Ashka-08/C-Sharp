/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
Ограничения:
- Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
- Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. 
Только в основном блоке кода или в функции вывода*/

int size = 8;
int[] nums = CreateArray(size);

PrintArray(nums);

int[] CreateArray(int size)
{
    nums = new int[size];
    Random rand = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
    nums[i] = rand.Next();
    }
    return nums;
}

void PrintArray(int[] array) 
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}
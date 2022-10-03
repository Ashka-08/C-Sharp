// Создание случайного массива заданного размера из 0 и 1 и вывод его на экран
// 8-> [1,0, 1, 1, 0, 0, ]

Console.Clear();

Console.Write("Введите размер массива: ");
int arrayLenhgt = int.Parse(Console.ReadLine()!);
int[] array = new int[arrayLenhgt];

FillArray(array);
PrintArray(array);

void FillArray(int[] array) //метод заполнения массива
{
    Random rand = new Random();
    for (int i = 0; i < arrayLenhgt; i++)
    {
    array[i] = rand.Next(0, 2);
    }
}

void PrintArray(int[] array) //метод вывода массива
{
    for (int i = 0; i < arrayLenhgt; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
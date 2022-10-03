/*задайте массив. Напишите программу, которая определяет 
присутствует ли заданное число в массиве
4; массив [6, 7, 19, 345, -3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да*/

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = new int[5];

FillArray(array);
PrintArray(array);
if (FindNumber(array, n))
    Console.WriteLine("да");
else
    Console.WriteLine("нет");

/*void FindNumber(int[] array, int n)
{for (int i = 0; i < 5; i++)
    {
    if (array[i] == n)
        {
        Console.WriteLine("да");
        break;
        }
    else if(i == 4)
        {
        Console.WriteLine("нет");
        }
    }
}*/

bool FindNumber(int[] array, int n)
{
    for (int i = 0; i < 5; i++)
    {
    if (array[i] == n)
        return true;
    }
    return false;
}
void FillArray(int[] array) 
{
    Random rand = new Random();
    for (int i = 0; i < 5; i++)
    {
    array[i] = rand.Next(-999, 1000);
    }
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

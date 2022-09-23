/* Программа, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

int count = 1;

while (count <= n)
{
    Console.Write(Math.Pow(count, 3));
    if(count != n)      // != значит не равно
        Console.Write(", ");
    count++;
}
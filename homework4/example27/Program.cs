/*Задача 27
Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
Ограничения:
- Должна быть отдельная функция, которая возвразает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = Result(num);
Console.WriteLine($"Сумма цифр в введенном числе: {sum}");

int Result(int num)
{
    int count = Convert.ToString(num).Length;
    int advance = 0;
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        advance = num - num % 10;
        sum = sum + (num - advance);
        num = num / 10;
    }
    return sum;
}
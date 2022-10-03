/*Задача 25 
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвразает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода*/

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

int PowerOfA = 1;

if (b < 0)
    b = -b;

Power(a, b);

Console.WriteLine(PowerOfA);

int Power (int a, int b)
{
    for (int i = 1; i <= b; i++)
    {
        PowerOfA = PowerOfA * a;
    }
    return PowerOfA;
}
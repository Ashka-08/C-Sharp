/* Программа, которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее */

Console.Clear();
Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

/* if(number1 == number2)
    Console.WriteLine("Числа равны");
else if(number2 > number1)
    Console.WriteLine($"max = {number2} min = {number1}");
else
    Console.WriteLine($"max = {number1} min = {number2}"); */

if(number1 < number2)
{
    Console.WriteLine($"max={number2} min={number1}");
}
else if(number2 < number1)
{
    Console.WriteLine($"max={number1} min={number2}");
}
else
{
    Console.WriteLine("Числа равны");
}
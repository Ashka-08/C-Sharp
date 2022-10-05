//Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Clear();
Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine());

/* if((number1 > number2) & (number1 > number3))
{
    Console.WriteLine($"max={number1}");
}
else if((number2 > number1) & (number2 > number3))
{
    Console.WriteLine($"max={number2}");
}
else if((number3 > number1) & (number3 > number2))
{
    Console.WriteLine($"max={number3}");
}
else 
{
    Console.WriteLine("Нет одного максимального числа");
}

 */
int max = number1;
if(number2 > max)
    max = number2;
if(number3 > max)
    max = number3;
Console.WriteLine($"max = {max}");
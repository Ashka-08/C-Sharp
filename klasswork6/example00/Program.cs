/*Задача. Напишите программу, которая принимает на вход число, 
и показывает количество цифр в числе
456 -> 3
78 -> 2*/

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Количество цифр в числе {Digits(number)}");

/*int Digits(int number, int count = 1)
{
    if (number / 10 == 0)
        return count;
    else 
    {
        return count + Digits(number / 10);
    }
}*/

int Digits(int number)
{
    if (number / 10 < 1)
        return 1;
    else
        return 1 + Digits(number/10);
}

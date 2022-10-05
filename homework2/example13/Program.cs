/*Программа, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if(number > 99)
{
    if(number >= 1000)
    {
        while(number >= 1000)
        {
            number = number / 10;
        }
        Console.WriteLine(number % 10);
    }
    else
    {
        Console.WriteLine(number % 10);
    }
}
else
    Console.WriteLine("Третьей цифры нет");
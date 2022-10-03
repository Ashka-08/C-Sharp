/*Программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);


if((number >= 10000) && (number < 100000)) {
    int digit5 = number / 10000;
    Console.WriteLine($"5 разряд числа равен {digit5}");
    
    int digit4 = number;   
    while(digit4 >= 10000)
        {
            digit4 = digit4 / 10;
        }
    digit4 = digit4 % 10;
    Console.WriteLine($"4 разряд числа равен {digit4}");

    int digit2 = number;
    while(digit2 >= 100)
        {
            digit2 = digit2 / 10;
        }
    digit2 = digit2 % 10;
    Console.WriteLine($"2 разряд числа равен {digit2}");

    int digit1 = number;
    while(digit1 >= 10)
        {
            digit1 = digit1 / 10;
        }
    digit1 = digit1 % 10;
    Console.WriteLine($"1 разряд числа равен {digit1}");

    if(digit5 == digit1 && digit4 == digit2)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else {
    Console.WriteLine($"Число {number} не подходит по условиям");
}
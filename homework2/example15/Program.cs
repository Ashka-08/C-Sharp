/*Программа, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным*/

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine()!);

if(number == 6)
        Console.WriteLine("Это выходной");
else if(number == 7)
        Console.WriteLine("Это выходной");
else if((number > 0) && (number < 8))
    Console.WriteLine("Это будний день");
else
    Console.WriteLine("Введено неверное число");
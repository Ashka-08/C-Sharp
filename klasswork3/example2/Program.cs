/* Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y)            
            |у
      2     |     1            
____________|____________
            |           х
      3     |     4
            |
*/


/* Console.Write("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine()!);

if(number == 1) {
    Console.Write("Условия для координат: х > 0, y > 0");
}
else if(number == 2) {
    Console.Write("Условия для координат: х < 0, y > 0");
}
else if(number == 3) {
    Console.Write("Условия для координат: х < 0, y < 0");
}
else if(number == 4) {
    Console.Write("Условия для координат: х > 0, y < 0");
}
else 
{
    Console.Write("Нет такой четверти");
} */

Console.Write("Введите номер четверти: ");
string number = Console.ReadLine();

switch(number) //альтернатива if/else, работает со string/int, но не с double
{
    case "1":
        Console.Write("х > 0, y > 0");
        break;
    case "2":
        Console.Write("х > 0, y > 0");
        break;
    case "3":
        Console.Write("х > 0, y > 0");
        break;
    case "4":
        Console.Write("х > 0, y > 0");
        break;
    default:
        Console.Write("Введено некорректное число");
        break;
}

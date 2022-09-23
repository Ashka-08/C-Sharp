/*Программа, которая принимает а вход координаты точки(х и у), 
причем х не равно 0 и у не равно 0 и выдает номер четверти плоскости,
в которой находитсяэта точка
            |у
      2     |     1            
____________|____________
            |           х
      3     |     4
            |
*/

Console.Write("Введите первую координату х: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую координату у: ");
int y = int.Parse(Console.ReadLine())!;

if(x > 0) {
    if(y > 0) {
        Console.WriteLine("1");
    }
    else 
    {
        Console.WriteLine("4");
    }
}
else
{
    if(y > 0) {
        Console.WriteLine("2");
    }
    else
    {
        Console.WriteLine("3");
    }
}
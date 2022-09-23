/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве. 

Расстояние - корень квадратов разницы координат:
      ______________________
АВ = / (х2 - х1) + (y2 - y1)

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 

square_a = a*a = Math.Pow(a, 2) квадрат числа
Math.Pow(a, 0.5) = Math.Sqrt(a) корень квадратный
Эти функции возвращают тип double*/

Console.Write("Введите x1: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите y1: ");
double y1 = double.Parse(Console.ReadLine())!;

Console.Write("Введите x2: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите y2: ");
double y2 = double.Parse(Console.ReadLine())!;

double d = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));

//d = Math.Round(d, 2); 
//оператор округления, где 2 - это кол-во символов после запятой

Console.WriteLine($"Длина отрезка между точками координат равна {d:f2}");
// :f2 этот формат также позволяет округлить до 2ух знаков после запятой

//Console.WriteLine(d.ToString("#.00")); 
//превращает в строку с таким же форматом, также округляет

